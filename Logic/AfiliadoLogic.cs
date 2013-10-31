using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance;
using Persistance.Entities;

namespace Logic
{
    public class AfiliadoLogic
    {
        private AfiliadoPersistance persistance;

        public AfiliadoLogic()
        {
            persistance = new AfiliadoPersistance();
        }

        public Afiliado GetByDocumento(TipoDocumento tipoDocumento, int numero)
        {
            return persistance.GetByDocumento(tipoDocumento, numero);
        }

        public bool Create(Afiliado afiliado, Afiliado conyugue, List<Afiliado> familiares)
        {
            return persistance.Create(afiliado, conyugue, familiares);
        }

        public bool Exist(Afiliado afiliado)
        {
            return GetByDocumento(afiliado.TipoDocumento, afiliado.Numero) != null;
        }
    }
}
