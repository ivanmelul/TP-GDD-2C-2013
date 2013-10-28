using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Horario : IMapable
    {
        public int ID { get; set; }
        public TimeSpan HoraInicio { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Horario toReturn = new Horario();

            toReturn.ID = Int32.Parse(reader["Horario_ID"].ToString());
            toReturn.HoraInicio = TimeSpan.Parse(reader["Horario_Hora"].ToString()); 
    
            return toReturn; 
        }

        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
