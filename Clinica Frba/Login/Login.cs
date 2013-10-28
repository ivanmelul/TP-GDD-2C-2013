using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Persistance.Entities;
using Logic;

namespace Clinica_Frba.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            try
            {
                if (string.IsNullOrEmpty(txtUser.Text))
                    throw new Exception("El Usuario no puede ser vacio");

                if (string.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception("La Contraseña no puede ser vacia");

                Usuario usuario = new UsuarioLogic().Login(txtUser.Text, txtPassword.Text);

                Home home = new Home(usuario);
                home.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUser_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoLogin();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new UsuarioLogic().Login("cliente", "cliente");

                Home home = new Home(usuario);
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCliente_Click_1(object sender, EventArgs e)
        {

        }

    }
}
