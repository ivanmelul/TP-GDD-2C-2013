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
using Clinica_Frba.Busquedas;
using Clinica_Frba.Utils;

namespace Clinica_Frba.ABM_Afiliado
{
    public partial class AgregarAfiliado : Form
    {
        FormSearchOwner _owner;

        private AfiliadoLogic _logic;

        private Dictionary<int, TipoDocumento> _tipoDocumento;
        private Dictionary<int, EstadoCivil> _estadoCivil;

        public AgregarAfiliado(FormSearchOwner owner, String tipo)
        {
            InitializeComponent();

            _owner = owner;

            if (tipo == "Conyugue")
            {
                BtnAddConyugue.Visible = true;
                BtnAddFamiliar.Visible = false;
            }
            else if (tipo == "Familiar")
            {
                BtnAddConyugue.Visible = false;
                BtnAddFamiliar.Visible = true;
            }

            Initialize();
        }

        public void Initialize()
        {
            _logic = new AfiliadoLogic();

            _estadoCivil = Initializator.EstadoCivil(CmbEstadoCivil);
            _tipoDocumento = Initializator.TipoDocumento(CmbTipo);
        }

        public Afiliado GetFormData()
        {
            try
            {
                Afiliado afiliado = new Afiliado();

                afiliado.Nombre = Validator.CheckEmptyOrNull(TxtNombre.Text);

                afiliado.Apellido = Validator.CheckEmptyOrNull(TxtApellido.Text);

                int id = Int32.Parse(CmbTipo.SelectedValue.ToString());
                afiliado.TipoDocumento = _tipoDocumento[id];

                afiliado.Numero = Validator.CheckInt(MskTxtNumero.Text);

                afiliado.Direccion = Validator.CheckEmptyOrNull(TxtDireccion.Text);

                afiliado.Telefono = Validator.CheckEmptyOrNull(MskTxtTelefono.Text);

                afiliado.FechaNacimiento = Validator.CheckDateTimeBeforeThanSystem(DtpFechaNacimiento.Value);

                Validator.AnyRadioChecked(GbAfiliado);
                afiliado.Sexo = RdoMasculino.Checked ? Sexo.Masculino : Sexo.Femenino;

                id = Int32.Parse(CmbEstadoCivil.SelectedValue.ToString());
                afiliado.EstadoCivil = _estadoCivil[id];

                return afiliado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void BtnAddFamiliar_Click(object sender, EventArgs e)
        {
            try
            {
                Afiliado familiar = GetFormData();

                if (_owner.Exist(familiar))
                    throw new Exception("Ya existe una persona con el mismo documento.");

                _owner.SelectedFamiliar(familiar);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddConyugue_Click(object sender, EventArgs e)
        {
            try
            {
                Afiliado conyugue = GetFormData();

                if (_owner.Exist(conyugue))
                    throw new Exception("Ya existe una persona con el mismo documento.");

                _owner.SelectedConyugue(conyugue);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            GbAfiliado.Controls.OfType<TextBox>().ToList().ForEach(x => x.Text = String.Empty);
            GbAfiliado.Controls.OfType<MaskedTextBox>().ToList().ForEach(x => x.Text = String.Empty);
            GbAfiliado.Controls.OfType<RadioButton>().ToList().ForEach(x => x.Checked = false);
            DtpFechaNacimiento.Value = Configuration.SystemDate;
        }
    }
}
