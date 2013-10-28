using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Dia : IMapable
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Dia toReturn = new Dia();

            toReturn.ID = Int32.Parse(reader["Dia_ID"].ToString());
            toReturn.Nombre = reader["Dia_Nombre"].ToString();

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
