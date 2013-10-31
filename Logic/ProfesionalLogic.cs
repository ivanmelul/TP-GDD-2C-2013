using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance;
using Persistance.Entities;

namespace Logic
{
    public class ProfesionalLogic
    {
        private ProfesionalPersistance persistance;

        public ProfesionalLogic()
        {
            persistance = new ProfesionalPersistance();
        }

        public Profesional GetByDocumento(TipoDocumento tipoDocumento, int numero)
        {
            return persistance.GetByDocumento(tipoDocumento, numero);
        }

        public bool Create(Profesional profesional)
        {
            return persistance.Create(profesional);
        }
    }
}
