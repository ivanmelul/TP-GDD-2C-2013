using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Turno : IMapable
    {
        public int ID{ get; set; }
        public Hora Hora { get; set; }
        public Profesional Profesional { get; set; }
        public Afiliado Afiliado { get; set; }
        public DateTime Fecha { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Turno toReturn = new Turno();

            toReturn.ID = int.Parse(reader["Turno_ID"].ToString());
            toReturn.Hora = (Hora)new Hora().Map(reader);
            toReturn.Fecha = DateTime.Parse(reader["Turno_Fecha"].ToString());
            toReturn.Afiliado = (Afiliado)new Afiliado().Map(reader);
            //No cambiar orden!!
            toReturn.Profesional = (Profesional)new Profesional().Map(reader);

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
