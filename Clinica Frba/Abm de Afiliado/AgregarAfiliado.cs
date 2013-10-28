using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Persistance.Entities;
using Clinica_Frba.Busquedas;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class AgregarAfiliado : Form
    {
        FormSearchOwner _owner;

        public AgregarAfiliado(FormSearchOwner owner, String tipo)
        {
            InitializeComponent();

            if (tipo == "Pajera")
            {
                BtnAddPareja.Visible = true;
                BtnAddFamiliar.Visible = false;
            }
            else if (tipo == "Familiar")
            {
                BtnAddPareja.Visible = false;
                BtnAddFamiliar.Visible = true;
            }
        }

        private void BtnAddFamiliar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddPareja_Click(object sender, EventArgs e)
        {

        }
    }
}
