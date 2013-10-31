using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;
using Persistance;

namespace Logic
{
    public class PlanMedicoLogic
    {
        private PlanMedicoPersistance persistance;

        public PlanMedicoLogic()
        {
            persistance = new PlanMedicoPersistance();
        }

        public List<PlanMedico> GetAll()
        {
            return persistance.GetAll();
        }
    }
}
