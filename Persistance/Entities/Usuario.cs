using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Usuario : IMapable
    {
        public int ID { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; } 
        public bool Habilitado { get; set; }
        public int LoginFails { get; set; }
        public List<Rol> Roles { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();
            usuario.ID = Int32.Parse(reader["Usuario_ID"].ToString());
            usuario.Password = reader["Usuario_Password"].ToString();
            usuario.Username = reader["Usuario_Nombre"].ToString();
            usuario.Habilitado = bool.Parse(reader["Usuario_Habilitado"].ToString());
            usuario.LoginFails = int.Parse(reader["Usuario_LoginFails"].ToString());

            usuario.Roles = new RolPersistance().GetByUser(usuario);

            return usuario;
        }

        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
