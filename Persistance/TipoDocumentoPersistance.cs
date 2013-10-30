using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;

namespace Persistance
{
    public class TipoDocumentoPersistance
    {
        public List<TipoDocumento> GetAll()
        {
            StoreProcedure sp = new StoreProcedure(DataBaseConst.TipoDocumento.SP_GetAllTipoDocumento);
            return sp.ExecuteReader<TipoDocumento>();
        }
    }
}
