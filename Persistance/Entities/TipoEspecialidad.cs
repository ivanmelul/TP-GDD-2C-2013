using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class TipoEspecialidad : IMapable
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            TipoEspecialidad toReturn = new TipoEspecialidad();

            toReturn.ID = Int32.Parse(reader["TipoEspecialidad_ID"].ToString());
            toReturn.Descripcion = reader["TipoEspecialidad_Descripcion"].ToString();

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
