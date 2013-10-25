using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Funcionalidad : IMapable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IMapable Map(SqlDataReader reader)
        {
            Funcionalidad func = new Funcionalidad();
            func.ID = int.Parse(reader["Func_ID"].ToString());
            func.Name = reader["Func_Nombre"].ToString();
            return func;
        }

        public List<SPParameter> UnMap(IMapable entity)
        { 
            return new List<SPParameter>(); 
        }
    }

    public enum Funcionalidades
    {
        ABM_Rol,
        ABM_Afiliado,
        ABM_Profesional,
        Registro_Agenda,
        Compra_Bono,
        Pedido_Turno,
        Registro_Llegada,
        Registro_Resultado,
        Cancelacion_Atencion,
        Emision_Receta,
        Estadisticas
    }
}
