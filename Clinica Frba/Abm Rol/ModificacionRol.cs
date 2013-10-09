using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;
using Logic;

namespace Clinica_Frba.Abm_Rol
{
    public partial class ModificacionRol : Form
    {
private RolLogic _rolesLogic;

        private FuncionalidadLogic _funcLogic;

        private Dictionary<int, Rol> _roles;

        private Rol _restore;

        public ModificacionRol()
        {
            InitializeComponent();

            _rolesLogic = new RolLogic();
            _funcLogic = new FuncionalidadLogic();

            // Seteo las funcionalidades disponibles
            Dictionary<int, String> funcs = _funcLogic.GetAll().ToDictionary(p => p.ID, p => p.Name);
            ChkLstFuncionalidades.DataSource = new BindingSource(funcs, null);
            ChkLstFuncionalidades.DisplayMember = "Value";
            ChkLstFuncionalidades.ValueMember = "Key";
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtSearch.Text = "";
            DgvRoles.DataSource = null;
            TxtNombre.Text = "";
            GbHolder.Enabled = false;

            foreach (int i in ChkLstFuncionalidades.CheckedIndices)
                ChkLstFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(TxtSearch.Text))
            //{
            //    MessageBox.Show("El campo 'Nombre de Rol' esta vacio.");
            //    return;
            //}

            if (ChkSearchExact.Checked)
            {
                // Busqueda EXACTA
                Rol rol = _rolesLogic.GetRolByNombre(TxtSearch.Text, false);

                if (rol == null)
                {
                    DgvRoles.DataSource = null;
                    return;
                }

                _roles = new Dictionary<int, Rol>();
                _roles.Add(rol.ID, rol);
            }
            else
            {
                // Busqueda LIKE
                _roles = _rolesLogic.GetRolesByNombre(TxtSearch.Text, false).ToDictionary(p => p.ID, p => p);
            }

            var bind = _roles.Values.Select(a => new
            {
                ID = a.ID,
                Nombre = a.Name,
                Habilitado = a.Habilitado
            });

            DgvRoles.DataSource = bind.ToList();
        }

        private void DgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GbHolder.Enabled = true;

            _restore = _roles[(int)DgvRoles.Rows[e.RowIndex].Cells[0].Value];

            SetFormData(_restore);
        }

        private Rol GetFormData()
        {
            Rol rol = new Rol();

            if (String.IsNullOrEmpty(TxtNombre.Text))
                throw new Exception("El nombre del rol esta vacio.");
            
            rol.Name = TxtNombre.Text;
            rol.Habilitado = ChkHabilitado.Checked;

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

                rol.Funcionalidades = funcs;
            }
            catch (Exception e)
            {
                throw new Exception("Problema con las funcionalidades.");
            }

            return rol;
        }

        private void SetFormData(Rol rol)
        {
            TxtNombre.Text = rol.Name.ToString();

            ChkHabilitado.Checked = rol.Habilitado;

            for (int j = 0; j < ChkLstFuncionalidades.Items.Count; j++)
            {
                KeyValuePair<int, String> item = (KeyValuePair<int, String>)ChkLstFuncionalidades.Items[j];

                if (rol.Funcionalidades.Any(p => p.Name == item.Value))
                    ChkLstFuncionalidades.SetItemChecked(j, true);
                else
                    ChkLstFuncionalidades.SetItemChecked(j, false);
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Rol nuevo = null;

            try
            {
                nuevo = GetFormData();
                nuevo.ID = _restore.ID;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Esta seguro que quiere modificar el Rol?", "Modificacion Rol", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_rolesLogic.Modify(_restore, nuevo))
                {
                    _restore = GetFormData();
                    MessageBox.Show("El Rol ha sido modificado correctamente.", "Modificacion Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Rol no ha sido modificado correctamente.", "Modificacion Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SetFormData(_restore);
        }
    }
}
