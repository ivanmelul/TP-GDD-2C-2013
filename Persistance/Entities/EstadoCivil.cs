using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class EstadoCivil : IMapable
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            EstadoCivil toReturn = new EstadoCivil();

            toReturn.ID = Int32.Parse(reader["EstadoCivil_ID"].ToString());
            toReturn.Nombre = reader["EstadoCivil_Nombre"].ToString();

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
