using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Persistance.Entities;
using Logic;

namespace Clinica_Frba.Utils
{
    public class Initializator
    {
        public Dictionary<int, TipoCancelacion> TipoCancelacion(ComboBox combo)
        {


            _ciudades = ciudades.ToDictionary(p => p.ID, p => p);
            Dictionary<int, String> comboCmb = ciudades.ToDictionary(p => p.ID, p => p.Name);

            combo.DataSource = new BindingSource(ciudadesCmb, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
        }

    }
}
