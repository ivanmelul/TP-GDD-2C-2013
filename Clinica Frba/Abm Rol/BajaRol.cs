using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
using Persistance.Entities;

namespace Clinica_Frba.Abm_Rol
{
    public partial class BajaRol : Form
    {
        private RolLogic _rolLogic;

        private Dictionary<int, Rol> _roles;

        public BajaRol()
        {
            InitializeComponent();

            _rolLogic = new RolLogic();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtSearch.Text = "";
            DgvRoles.DataSource = null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(TxtSearch.Text))
            //{
                //MessageBox.Show("El campo 'Nombre de Rol' esta vacio.");
                //return;
            //}

            if (ChkSearchExact.Checked)
            {
                // Busqueda EXACTA
                Rol rol = _rolLogic.GetRolByNombre(TxtSearch.Text, true);

                _roles = new Dictionary<int, Rol>();
                _roles.Add(rol.ID, rol);
            }
            else
            {
                // Busqueda LIKE
                _roles = _rolLogic.GetRolesByNombre(TxtSearch.Text, true).ToDictionary(p => p.ID, p => p);
            }

            var bind = _roles.Values.Select(a => new
            {
                ID = a.ID,
                Nombre = a.Name
            });

            DgvRoles.DataSource = bind.ToList();
        }

        private void DgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 || DgvRoles.ColumnCount == 1)
                return;

            Rol rol = _roles[(int)DgvRoles.Rows[e.RowIndex].Cells[1].Value];

            if (MessageBox.Show("¿Esta seguro que quiere dar de baja el Rol?", "Baja Rol", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_rolLogic.Delete(rol))
                {
                    MessageBox.Show("El Rol ha sido dado de baja correctamente.", "Baja Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("El Rol no ha sido dado de baja correctamente.", "Baja Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
