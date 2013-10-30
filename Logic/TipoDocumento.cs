using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;
using Persistance;

namespace Logic
{
    public class TipoDocumentoLogic
    {
        private TipoDocumentoPersistance persistance;

        public TipoDocumentoLogic()
        {
            persistance = new TipoDocumentoPersistance();
        }

        public List<TipoDocumento> GetAll()
        {
            return persistance.GetAll();
        }
    }
}
