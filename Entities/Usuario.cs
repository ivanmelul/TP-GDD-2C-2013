using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Entities
{
    public class Usuario : IMapable
    {
        public int ID { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; } 
        public bool Habilitado { get; set; }
        public int LoginFails { get; set; }
        public List<Rol> Roles { get; set; }

        public IMapable Map(SqlDataReader reader) { return new Usuario(); }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
