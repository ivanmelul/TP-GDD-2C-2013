using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class TipoCancelacion : IMapable
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            TipoCancelacion toReturn = new TipoCancelacion();

            toReturn.ID = Int32.Parse(reader["TipoCancelacion_ID"].ToString());
            toReturn.Nombre = reader["TipoCancelacion_Nombre"].ToString();

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
