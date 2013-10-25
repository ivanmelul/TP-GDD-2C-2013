using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Entities
{
    public class Especialidad : IMapable
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public TipoEspecialidad TipoEspecialidad { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader) { return new Especialidad(); }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }

    
}
