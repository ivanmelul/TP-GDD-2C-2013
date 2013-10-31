using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;

namespace Persistance
{
    public class AgendaPersistance
    {
        public List<Horario> GetHorariosByAgenda(Agenda agenda)
        {
            List<SPParameter> parameters = new List<SPParameter>();
            parameters.Add(new SPParameter("agendaId", agenda.ID));

            StoreProcedure sp = new StoreProcedure(DataBaseConst.Agenda.SP_GetAllHorarioByAgendaId, parameters);
            return sp.ExecuteReader<Horario>();
        }
    }
}
