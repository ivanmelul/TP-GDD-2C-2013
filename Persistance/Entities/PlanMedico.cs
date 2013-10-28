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
        public decimal PrecioFarmacia { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            PlanMedico toReturn = new PlanMedico();

            toReturn.ID = Int32.Parse(reader["PlanMedico_ID"].ToString());
            toReturn.Nombre = reader["PlanMedico_Nombre"].ToString();
            toReturn.PrecioConsulta = decimal.Parse(reader["PlanMedico_PrecioConsulta"].ToString());
            toReturn.PrecioFarmacia = decimal.Parse(reader["PlanMedico_PrecioFarmacia"].ToString());

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
