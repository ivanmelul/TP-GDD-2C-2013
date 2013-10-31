using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Busquedas;
using Clinica_Frba.Utils;
using Persistance.Entities;
using Logic;

namespace Clinica_Frba.ABM_Afiliado
{
    public partial class FormAltaAfiliado : FormSearchOwner
    {
        public FormAltaAfiliado()
        {
            InitializeComponent();

            Initialize();
        }

        private AfiliadoLogic _logic;

        private Dictionary<int, TipoDocumento> _tipoDocumento;
        private Dictionary<int, EstadoCivil> _estadoCivil;
        private Dictionary<int, PlanMedico> _planMedico;

        private Afiliado _afiliado;
        private Afiliado _conyugue;
        private List<Afiliado> _familiares;
        private int _familiaresCount;

        public void Initialize()
        {
            _logic = new AfiliadoLogic();
            
            _estadoCivil = Initializator.EstadoCivil(CmbEstadoCivil);
            _tipoDocumento = Initializator.TipoDocumento(CmbTipo);
            _planMedico = Initializator.PlanMedico(CmbPlanMedico);

            CleanUI();
            CleanWorkflow();
        }

        private void CleanUI()
        {
            GbAfiliado.Controls.OfType<TextBox>().ToList().ForEach(x => x.Text = String.Empty);
            GbAfiliado.Controls.OfType<MaskedTextBox>().ToList().ForEach(x => x.Text = String.Empty);
            GbAfiliado.Controls.OfType<RadioButton>().ToList().ForEach(x => x.Checked = false);
            DtpFechaNacimiento.Value = Configuration.SystemDate;

            GbAfiliado.Enabled = true;
            GbAsociados.Enabled = false;
        }

        private void CleanWorkflow()
        {
            _afiliado = null;
            _conyugue = null;
            _familiares = new List<Afiliado>();
            _familiaresCount = 0;
        }

        private Afiliado GetFormData()
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

                id = Int32.Parse(CmbPlanMedico.SelectedValue.ToString());
                afiliado.PlanMedico = _planMedico[id];

                _familiaresCount = Validator.CheckInt(TxtCantidadFamiliares.Text);

                return afiliado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void BtnAddAsociados_Click(object sender, EventArgs e)
        {
            try
            {
                _afiliado = GetFormData();

                if (Exist(_afiliado))
                {
                    _afiliado = null;
                    MessageBox.Show("Ya ha ingresado o existe un afiliado con el mismo Documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_familiares.Count <= 0 || !_afiliado.TieneConyugue )
                {
                    _afiliado = null;
                    MessageBox.Show("No puede asociar a nadie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GbAfiliado.Enabled = false;
                GbAsociados.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCleanAsociados_Click(object sender, EventArgs e)
        {

            GbAfiliado.Enabled = true;
            GbAsociados.Enabled = false;
            ClearConyugue();
            ClearFamiliares();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_afiliado == null)
                    _afiliado = GetFormData();
                

                if (Exist(_afiliado))
                {
                    _afiliado = null;
                    MessageBox.Show("Ya ha ingresado o existe un afiliado con el mismo Documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _logic.Create(_afiliado, _conyugue, _familiares);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Asociar Conyugue

        private void BtnAddConyugue_Click(object sender, EventArgs e)
        {
            AgregarAfiliado form = new AgregarAfiliado(this, "Conyugue");
            form.Show();
        }

        public override void SelectedConyugue(Afiliado conyugue)
        {
            if (Exist(conyugue))
            {
                MessageBox.Show("Ya ha ingresado o existe un afiliado con el mismo Documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _conyugue = conyugue;
        }

        private void BtnCleanConyugue_Click(object sender, EventArgs e)
        {
            ClearConyugue();
        }

        private void ClearConyugue()
        {
            _conyugue = null;
            TxtConyugue.Text = String.Empty;
        }

        // Asociar Familiar

        private void BtnAddFamiliar_Click(object sender, EventArgs e)
        {
            AgregarAfiliado form = new AgregarAfiliado(this, "Familiar");
            form.Show();
        }

        public override void SelectedFamiliar(Afiliado familiar)
        {
            if (Exist(familiar))
            {
                MessageBox.Show("Ya ha ingresado o existe un afiliado con el mismo Documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddFamiliar(familiar);
        }

        private void BtnCleanFamiliar_Click(object sender, EventArgs e)
        {
            String documento = (String)LstFamiliares.SelectedValue;
            DeleteFamiliar(documento);
        }

        private void BtnCleanFamiliares_Click(object sender, EventArgs e)
        {
            ClearFamiliares();
        }

        private void AddFamiliar(Afiliado familiar)
        {
            _familiares.Add(familiar);
            UpdateFamiliaresList();
        }

        private void DeleteFamiliar(String documento)
        {
            _familiares.RemoveAll(f => f.DisplayDocumento == documento);
            UpdateFamiliaresList();
        }

        private void ClearFamiliares()
        {
            _familiares.Clear();
            LstFamiliares.DataSource = null;
        }

        private void UpdateFamiliaresList()
        {
            if (_familiares.Count == 0) return;

            Dictionary<String, String> comboCmb = _familiares.ToDictionary(f => f.DisplayDocumento, f => f.DisplayName);

            LstFamiliares.DataSource = null;
            LstFamiliares.DataSource = new BindingSource(comboCmb, null);
            LstFamiliares.DisplayMember = "Value";
            LstFamiliares.ValueMember = "Key";
        }

        // Chequea localmente y en la DB si ya está ingresado el afiliado
        public override bool Exist(Afiliado afiliado)
        {
            
            if (_logic.Exist(afiliado))
                return true;

            if (_afiliado != null)
            {
                if (_afiliado.DisplayDocumento == afiliado.DisplayDocumento)
                    return true;
            }

            foreach (Afiliado familiar in _familiares)
            {
                if (familiar.DisplayDocumento == afiliado.DisplayDocumento)
                    return true;
            }

            return false;
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanUI();
            ClearConyugue();
            ClearFamiliares();
            CleanWorkflow();
        }
        

    }
}
