using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Hora : IMapable
    {
        public int ID { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Fin { get { return Inicio.Add(new TimeSpan(0, 30, 0)); } }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Hora toReturn = new Hora();

            toReturn.ID = Int32.Parse(reader["Horario_ID"].ToString());
            toReturn.Inicio = TimeSpan.Parse(reader["Horario_Inicio"].ToString());

            return toReturn;
        }

        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
