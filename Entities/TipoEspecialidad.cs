using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Entities
{
    public class TipoEspecialidad : IMapable
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public IMapable Map(SqlDataReader reader) { return new TipoEspecialidad(); }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
