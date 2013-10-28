using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class TipoDocumento : IMapable
    {
        public int ID { get; set; }
        public string Tipo { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            TipoDocumento toReturn = new TipoDocumento();

            toReturn.ID = Int32.Parse(reader["TipoDocumento_ID"].ToString());
            toReturn.Tipo = reader["TipoDocumento_Tipo"].ToString();

            return toReturn;
        }

        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
