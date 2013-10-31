using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;

namespace Persistance
{
    public class PlanMedicoPersistance
    {
        public List<PlanMedico> GetAll()
        {
            StoreProcedure sp = new StoreProcedure(DataBaseConst.PlanMedico.SP_GetAllPlanMedico);
            return sp.ExecuteReader<PlanMedico>();
        }
    }
}
