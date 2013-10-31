using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;
using Persistance;

namespace Logic
{
    public class EspecialidadLogic
    {
        private EspecialidadPersistance persistance;

        public EspecialidadLogic()
        {
            persistance = new EspecialidadPersistance();
        }

        public List<Especialidad> GetAll()
        {
            return persistance.GetAll();
        }
    }
}
