using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;

namespace Persistance
{
    public class ProfesionalPersistance
    {
        public Profesional GetByDocumento(TipoDocumento tipoDocumento, int numero)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("tipoDocumentoId", tipoDocumento.ID));
            param.Add(new SPParameter("afiliadoNumero", numero));

            StoreProcedure sp = new StoreProcedure(DataBaseConst.Profesional.SP_GetProfesionalByDocumento, param);
            List<Profesional> profesionales = sp.ExecuteReader<Profesional>();
            return profesionales.Count > 0 ? profesionales[0] : null;
        }

        public bool Create(Profesional profesional)
        {
            return true;
        }
    }
}
