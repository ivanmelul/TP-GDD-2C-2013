using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Funcionalidad : Entidad
    {
        public string Name { get; set; }
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
