using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Especialidad : IMapable
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public TipoEspecialidad TipoEspecialidad { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Especialidad toReturn = new Especialidad();

            toReturn.ID = Int32.Parse(reader["Especialidad_ID"].ToString());
            toReturn.Descripcion = reader["Especialidad_Descripcion"].ToString();
            toReturn.TipoEspecialidad = (TipoEspecialidad) new TipoEspecialidad().Map(reader);

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }

    
}
