using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Entities
{
    public class Dia : IMapable
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader) { return new Dia(); }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
