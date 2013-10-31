using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;

namespace Persistance
{
    public class AfiliadoPersistance
    {
        public Afiliado GetByDocumento(TipoDocumento tipoDocumento, int numero)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("tipoDocumentoId", tipoDocumento.ID));
            param.Add(new SPParameter("afiliadoNumero", numero));

            StoreProcedure sp = new StoreProcedure(DataBaseConst.Afiliado.SP_GetAfiliadoByDocumento, param);
            List<Afiliado> afiliados = sp.ExecuteReader<Afiliado>();
            return afiliados.Count > 0 ? afiliados[0] : null;
        }

        public bool Create(Afiliado afiliado, Afiliado conyugue, List<Afiliado> familiares)
        {
            return true;
        }
    }
}
