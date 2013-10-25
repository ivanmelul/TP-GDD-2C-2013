using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Profesional : IMapable
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

        public IMapable Map(SqlDataReader reader) { return new Profesional(); }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }

    public enum Sexo { 
        Masculino,
        Femenino
    }
}
