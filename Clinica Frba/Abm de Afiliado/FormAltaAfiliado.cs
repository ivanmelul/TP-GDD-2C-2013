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

namespace Clinica_Frba.NewFolder12
{
    public partial class FormAltaAfiliado : FormSearchOwner
    {
        public FormAltaAfiliado()
        {
            InitializeComponent();
        }

        private Dictionary<int, TipoDocumento> _tipoDocumento;

        private void GetFormData()
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
            }
            catch (Exception e) { }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
