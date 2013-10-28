using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Persistance.Entities;

namespace Persistance
{
    public class EspecialidadPersistance
    {

        public List<Especialidad> GetByProfesional(Profesional prof)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("profesionalDNI", prof.DNI));

            StoreProcedure sp = new StoreProcedure(DataBaseConst.Especialidad.SP_GetAllEspecialidadByProfesional, param);
            return sp.ExecuteReader<Especialidad>();
        }
    }
}
