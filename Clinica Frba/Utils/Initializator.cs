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
        private static TipoDocumentoLogic _tipoDocumentoLogic = new TipoDocumentoLogic();
        private static EstadoCivilLogic _estadoCivilLogic = new EstadoCivilLogic();
        private static PlanMedicoLogic _planMedicoLogic = new PlanMedicoLogic();

        public static Dictionary<int, TipoDocumento> TipoDocumento(ComboBox combo)
        {
            Dictionary<int, TipoDocumento> tipoDocumentos = _tipoDocumentoLogic.GetAll().ToDictionary(p => p.ID, p => p);
            Dictionary<int, String> comboCmb = tipoDocumentos.Values.ToDictionary(p => p.ID, p => p.Tipo);

            combo.DataSource = new BindingSource(comboCmb, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";

            return tipoDocumentos;
        }

        public static Dictionary<int, EstadoCivil> EstadoCivil(ComboBox combo)
        {
            Dictionary<int, EstadoCivil> estadoCivil = _estadoCivilLogic.GetAll().ToDictionary(p => p.ID, p => p);
            Dictionary<int, String> comboCmb = estadoCivil.Values.ToDictionary(p => p.ID, p => p.Nombre);

            combo.DataSource = new BindingSource(comboCmb, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";

            return estadoCivil;
        }

        public static Dictionary<int, PlanMedico> PlanMedico(ComboBox combo)
        {
            Dictionary<int, PlanMedico> planMedico = _planMedicoLogic.GetAll().ToDictionary(p => p.ID, p => p);
            Dictionary<int, String> comboCmb = planMedico.Values.ToDictionary(p => p.ID, p => p.Nombre);

            combo.DataSource = new BindingSource(comboCmb, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";

            return planMedico;
        }

    }
}
