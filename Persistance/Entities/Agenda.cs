using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Agenda : IMapable
    {
        public int ID { get; set; }
        public Profesional Profesional { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public List<Horario> Horarios { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Agenda toReturn = new Agenda();

            toReturn.ID = Int32.Parse(reader["Agenda_ID"].ToString());
            
            toReturn.Desde = DateTime.Parse(reader["Agenda_Desde"].ToString());
            toReturn.Hasta= DateTime.Parse(reader["Agenda_Hasta"].ToString());
            toReturn.Profesional = (Profesional)(new Profesional().Map(reader));
            reader.Close();
            
            toReturn.Horarios = new AgendaPersistance().GetHorariosByAgenda(toReturn);

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
