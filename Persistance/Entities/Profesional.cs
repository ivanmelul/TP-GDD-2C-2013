using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Profesional : IMapable
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DisplayName { get { return string.Format("{0} {1}", Nombre, Apellido); } }
        public TipoDocumento TipoDocumento { get; set; }
        public int Numero { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Matricula { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool EsBaja { get { return !FechaBaja.HasValue; } }

        public List<Especialidad> Especialidades { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            Profesional toReturn = new Profesional();

            toReturn.ID = Int32.Parse(reader["Profesional_ID"].ToString());
            toReturn.Numero = Int32.Parse(reader["Profesional_Numero"].ToString());
            toReturn.TipoDocumento = (TipoDocumento) new TipoDocumento().Map(reader);
            toReturn.Nombre = reader["Profesional_Nombre"].ToString();
            toReturn.Apellido= reader["Profesional_Apellido"].ToString();
            toReturn.Direccion = reader["Profesional_Direccion"].ToString();
            toReturn.Telefono = reader["Profesional_Telefono"].ToString();
            toReturn.Mail = reader["Profesional_Mail"].ToString();
            toReturn.FechaNacimiento = DateTime.Parse(reader["PlanMedico_FechaNacimiento"].ToString());
            toReturn.Matricula = reader["Profesional_Matricula"].ToString();

            DateTime fechaBaja;
            if (DateTime.TryParse(reader["Profesional_FechaBaja"].ToString(), out fechaBaja))
                toReturn.FechaBaja = fechaBaja;
            else
                toReturn.FechaBaja = null;

            toReturn.Sexo = reader["Profesional_Sexo"].ToString().ToUpper() == "M" ? Sexo.Masculino : Sexo.Femenino;

            toReturn.Especialidades = new EspecialidadPersistance().GetByProfesional(toReturn);

            return toReturn;
        }

        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }

    public enum Sexo { 
        Masculino,
        Femenino
    }
}
