using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Rol : Entidad
    {
        public string Name { get; set; }   
        public bool Habilitado { get; set; }
        public List<Funcionalidad> Funcionalidades { get; set; }
    }
}
