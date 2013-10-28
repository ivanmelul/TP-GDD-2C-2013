using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Utils
{
    public class Validator
    {
        public static bool CheckEmptyOrNull(String str)
        {
            if (String.IsNullOrEmpty(str))
                throw new Exception("Cadena nula o vacia.");

            return true;
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

    }
}
