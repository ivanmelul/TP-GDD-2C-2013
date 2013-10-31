using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;
using Persistance;

namespace Logic
{
    public class EstadoCivilLogic
    {
        private EstadoCivilPersistance persistance;

        public EstadoCivilLogic()
        {
            persistance = new EstadoCivilPersistance();
        }

        public List<EstadoCivil> GetAll()
        {
            return persistance.GetAll();
        }
    }
}
