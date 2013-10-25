using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Rol : IMapable
    {
        public int ID { get; set; }
        public string Name { get; set; }   
        public bool Habilitado { get; set; }
        public List<Funcionalidad> Funcionalidades { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Rol rol = new Rol();
            rol.ID = Int32.Parse(reader["Rol_ID"].ToString());
            rol.Name = ((String)reader["Rol_Nombre"]).Trim();
            rol.Habilitado = bool.Parse(reader["Rol_Habilitado"].ToString());

            rol.Funcionalidades = new FuncionalidadPersistance().GetByRol(rol);

            return rol;
        }

        public List<SPParameter> UnMap(IMapable entity)
        { 
            return new List<SPParameter>();
        }
    }
}
