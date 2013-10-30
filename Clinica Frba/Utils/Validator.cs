using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Utils
{
    public class Validator
    {
        public static String CheckEmptyOrNull(String str)
        {
            if (String.IsNullOrEmpty(str))
                throw new Exception("Cadena nula o vacia. Verifique los campos.");

            return str;
        }

        public static int CheckInt(String str)
        {
            CheckEmptyOrNull(str);

            int aux = 0;

            if (Int32.TryParse(str, out aux))
                return aux;
            else
                throw new Exception("La cadena '" + aux + "' no es un numero entero valido.");
        }

        public static DateTime CheckDateTimeBeforeThanSystem(DateTime date)
        {
            if (Configuration.SystemDate >= date)
                throw new Exception("Fecha invalida.");

            return date;
        }

        public static void AnyRadioChecked(GroupBox groupBox)
        {
            if (groupBox.Controls.OfType<RadioButton>().Any(x => x.Checked))
                return;

            throw new Exception("Por favor seleccione una opcion.");
        }

    }
}
