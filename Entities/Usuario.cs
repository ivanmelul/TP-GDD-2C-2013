using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Usuario : Entidad
    {
        public string Username { get; set; } 
        public string Password { get; set; } 
        public bool Habilitado { get; set; }
        public int LoginFails { get; set; }
        public List<Rol> Roles { get; set; }
    }
}
