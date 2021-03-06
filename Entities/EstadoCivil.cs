﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Entities
{
    public class EstadoCivil : IMapable
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public IMapable Map(SqlDataReader reader) { return new EstadoCivil(); }
        public List<SPParameter> UnMap(IMapable entity) { return new List<SPParameter>(); }
    }
}
