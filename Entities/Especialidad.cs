using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Especialidad : Entidad
    {
        public string Descripcion { get; set; }
        public TipoEspecialidad TipoEspecialidad { get; set; }
    }
}
