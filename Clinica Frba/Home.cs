using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.AbmProfesional;
using Persistance.Entities;
using Logic;

namespace Clinica_Frba
{
    public partial class Home : Form
    {
        private RolLogic rolLogic;
        private Dictionary<int, Rol> _roles;
        private Rol selectedRol;
        private Usuario _usuario;

        public Home()
        {
            InitializeComponent();
        }

        public Home(Usuario usuario)
        {
            _usuario = usuario;
            rolLogic = new RolLogic();
            InitializeComponent();

            List<Rol> roles = rolLogic.GetAll();
            _roles = roles.ToDictionary(p => p.ID, p => p);
            cmbRoles.DataSource = new BindingSource(roles.ToDictionary(p => p.ID, p => p.Name), null);
            cmbRoles.DisplayMember = "Value";
            cmbRoles.ValueMember = "Key";
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(cmbRoles.SelectedValue.ToString(), out id))
                selectedRol = _roles[id];
            else
                throw new Exception("Hubo un error en el rol seleccionado.");

            ShowButtons();
        }

        private void ShowButtons()
        {
            if (selectedRol.Funcionalidades.Count > 0)
                gpbFuncionalidades.Visible = true;

            LblRol.Text = _usuario.Username;

            foreach (var func in selectedRol.Funcionalidades)
            {        
                switch (GetEnum(func.Name))
                {
                    case Funcionalidades.ABM_Afiliado:
                        gpbAfiliados.Visible = true;
                        break;
                    case Funcionalidades.ABM_Profesional:
                        gpbProfesionales.Visible = true;
                        break;
                    case Funcionalidades.ABM_Rol:
                        GpbRoles.Visible = true;
                        break;
                    case Funcionalidades.Registro_Agenda:
                        btnRegitrarAgenda.Visible = true;
                        break;
                    case Funcionalidades.Compra_Bono:
                        btnComprarBono.Visible = true;
                        break;
                    case Funcionalidades.Pedido_Turno:
                        btnPedidoTurno.Visible = true;
                        break;
                    case Funcionalidades.Registro_Llegada:
                        btnRegistrarLlegada.Visible = true;
                        break;
                    case Funcionalidades.Estadisticas:
                        btnEstadisticas.Visible = true;
                        break;
                    case Funcionalidades.Registro_Resultado:
                        btnRegitrarResultado.Visible = true;
                        break;
                    case Funcionalidades.Cancelacion_Atencion:
                        btnCancelarAtencion.Visible = true;
                        break;
                    case Funcionalidades.Emision_Receta:
                        btnEmitirReceta.Visible = true;
                        break;
                    default: break;
                }
            }
        }

        private Funcionalidades? GetEnum(string func)
        {        
            if (func == "ABM Roles") return Funcionalidades.ABM_Rol;
            if (func == "ABM Afiliados") return Funcionalidades.ABM_Afiliado;
            if (func == "ABM Profesionales") return Funcionalidades.ABM_Profesional;
            if (func == "Registrar Agenda") return Funcionalidades.Registro_Agenda;
            if (func == "Comprar Bono") return Funcionalidades.Compra_Bono;
            if (func == "Pedir Turno") return Funcionalidades.Pedido_Turno;
            if (func == "Registrar Llegada") return Funcionalidades.Registro_Llegada;
            if (func == "Registrar Resultados") return Funcionalidades.Registro_Resultado;
            if (func == "Cancelar Atencion") return Funcionalidades.Cancelacion_Atencion;
            if (func == "Emitir Receta") return Funcionalidades.Emision_Receta;
            if (func == "Estadisticas") return Funcionalidades.Estadisticas;

            return null;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Login.frmLogin login = new Clinica_Frba.Login.frmLogin();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbmProfesional.frmAltaProfesional form = new frmAltaProfesional();
            form.Show();
            this.Hide();
        }
    }
}
