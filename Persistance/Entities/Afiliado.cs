using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Afiliado : IMapable
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
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public PlanMedico PlanMedico { get; set; }
        public int NumeroAfiliadoBase { get; set; }
        public int NumeroAfiliadoFamiliar { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool EsBaja { get { return !FechaBaja.HasValue; } }

        public IMapable Map(SqlDataReader reader)
        {
            Afiliado toReturn = new Afiliado();

            toReturn.ID = Int32.Parse(reader["Afiliado_ID"].ToString());
            toReturn.Numero = Int32.Parse(reader["Afiliado_Numero"].ToString());
            toReturn.TipoDocumento = (TipoDocumento)new TipoDocumento().Map(reader);
            toReturn.Nombre = reader["Afiliado_Nombre"].ToString();
            toReturn.Apellido = reader["Afiliado_Apellido"].ToString();
            toReturn.Direccion = reader["Afiliado_Direccion"].ToString();
            toReturn.Telefono = reader["Afiliado_Telefono"].ToString();
            toReturn.Mail = reader["Afiliado_Mail"].ToString();
            toReturn.FechaNacimiento = DateTime.Parse(reader["Afiliado_FechaNacimiento"].ToString());

            toReturn.Sexo = reader["Afiliado_Sexo"].ToString().ToUpper() == "M" ? Sexo.Masculino : Sexo.Femenino;

            toReturn.EstadoCivil = (EstadoCivil)new EstadoCivil().Map(reader);

            DateTime fechaBaja;
            if (DateTime.TryParse(reader["Afiliado_FechaBaja"].ToString(), out fechaBaja))
                toReturn.FechaBaja = fechaBaja;
            else
                toReturn.FechaBaja = null;

            return toReturn;
        }

        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
