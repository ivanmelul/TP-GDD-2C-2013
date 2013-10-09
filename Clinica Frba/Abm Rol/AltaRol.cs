using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
using Entities;

namespace Clinica_Frba.Abm_Rol
{
    public partial class AltaRol : Form
    {
        private RolLogic _rolLogic;

        private FuncionalidadLogic _funcLogic;

        public AltaRol()
        {
            InitializeComponent();

            InitializeForm();
        }

        private void InitializeForm()
        {
            _rolLogic = new RolLogic();
            _funcLogic = new FuncionalidadLogic();

            // Seteo las funcionalidades disponibles
            Dictionary<int, String> funcs = _funcLogic.GetAll().ToDictionary(p => p.ID, p => p.Name);
            ChkLstFuncionalidades.DataSource = new BindingSource(funcs, null);
            ChkLstFuncionalidades.DisplayMember = "Value";
            ChkLstFuncionalidades.ValueMember = "Key";
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";

            foreach (int i in ChkLstFuncionalidades.CheckedIndices)
                ChkLstFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
        }

        private Rol GetFormData()
        {
            Rol rol = new Rol();

            if (String.IsNullOrEmpty(TxtNombre.Text))
                throw new Exception("El nombre del rol es obligatorio.");
        
            rol.Name = TxtNombre.Text;
            rol.Habilitado = true;
            try
            {
                List<Funcionalidad> funcs = new List<Funcionalidad>();

                foreach (object item in ChkLstFuncionalidades.CheckedItems)
                {
                    Funcionalidad func = new Funcionalidad();
                    KeyValuePair<int, String> pair = (KeyValuePair<int, String>)item;
                    func.ID = pair.Key;
                    func.Name = pair.Value;

                    funcs.Add(func);
                }

                if (funcs.Count ==0)
                    throw new Exception("Debe elegir al menos una funcionalidad.");

                rol.Funcionalidades = funcs;
            }
            catch (Exception e)
            {
                throw e;
            }

            return rol;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Rol nuevo = null;
            
            try
            {
                nuevo = GetFormData();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_rolLogic.GetRolByNombre(nuevo.Name, false) != null)
            {
                MessageBox.Show("Ya existe un Rol con ese nombre.", "Creacion Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_rolLogic.Create(nuevo))
            {
                MessageBox.Show("El Rol ha sido creado correctamento.", "Creacion Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El Rol no ha sido creado correctamente.", "Creacion Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {

        }
    }
}
