using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Profesional
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DisplayName { get { return string.Format("{0} {1}", Nombre, Apellido); } }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Matricula { get; set; }
        public bool Baja { get; set; }
        public Sexo Sexo { get; set; }
    }

    public enum Sexo { 
        Masculino,
        Femenino
    }
}
