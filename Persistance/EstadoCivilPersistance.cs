using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;

namespace Persistance
{
    public class EstadoCivilPersistance
    {
        public List<EstadoCivil> GetAll()
        {
            StoreProcedure sp = new StoreProcedure(DataBaseConst.EstadoCivil.SP_GetAllEstadoCivil);
            return sp.ExecuteReader<EstadoCivil>();
        }
    }
}
