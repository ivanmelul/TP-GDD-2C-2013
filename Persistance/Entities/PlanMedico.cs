using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class PlanMedico : IMapable
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioConsulta { get; set; }
        public decimal PrecioBono { get; set; }

        public IMapable Map(SqlDataReader reader) { return new PlanMedico(); }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
