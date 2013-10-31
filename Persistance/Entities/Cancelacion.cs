using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Cancelacion : IMapable
    {
        public int ID{ get; set; }
        public TipoCancelacion TipoCancelacion { get; set; }
        public string Motivo { get; set; }
        public CanceladoPor CanceladoPor { get; set; }
        public DateTime Fecha { get; set; }
        public Turno Turno { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Cancelacion toReturn = new Cancelacion();

            toReturn.ID = int.Parse(reader["Cancelacion_ID"].ToString());
            toReturn.TipoCancelacion = (TipoCancelacion)new TipoCancelacion().Map(reader);
            toReturn.Motivo = reader["Cancelacion_Motivo"].ToString();
            toReturn.CanceladoPor = reader["Cancelacion_CanceladoPor"].ToString().ToUpper() == "P" ? CanceladoPor.Paciente : CanceladoPor.Medico;
            toReturn.Fecha = DateTime.Parse(reader["Cancelacion_Fecha"].ToString());
            //No cambiar orden!!
            toReturn.Turno = (Turno)new Turno().Map(reader);

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }

    public enum CanceladoPor { 
        Paciente,
        Medico
    }
}
