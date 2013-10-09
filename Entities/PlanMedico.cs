using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class PlanMedico : Entidad
    {
        public string Nombre { get; set; }
        public decimal PrecioConsulta { get; set; }
        public decimal PrecioBono { get; set; }
    }
}
