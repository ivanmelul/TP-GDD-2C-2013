﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Persistance.Entities
{
    public class Horario : IMapable
    {
        public Hora Hora{ get; set; }
        public Dia Dia { get; set; }

        //Implement of IMapable

        public IMapable Map(SqlDataReader reader)
        {
            Horario toReturn = new Horario();

            toReturn.Hora = (Hora)new Hora().Map(reader);
            toReturn.Dia = (Dia)new Dia().Map(reader);

            return toReturn;
        }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
