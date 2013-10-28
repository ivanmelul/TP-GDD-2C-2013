using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Persistance.Entities;

namespace Persistance
{
    public class FuncionalidadPersistance
    {
        public List<Funcionalidad> GetAll()
        {
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Funcionalidad.SP_GetAllFuncionalidad);
            return sp.ExecuteReader<Funcionalidad>();
        }

        public List<Funcionalidad> GetByRol(Rol rol)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("rolId", rol.ID));

            StoreProcedure sp = new StoreProcedure(DataBaseConst.Funcionalidad.SP_GetAllFuncionalidadByRol, param);
            return sp.ExecuteReader<Funcionalidad>();
        }

        public void InsertByRol(Rol rol)
        {
            foreach (Funcionalidad func in rol.Funcionalidades)
            {
                List<SPParameter> param = new List<SPParameter>();
                param.Add(new SPParameter("funcId", func.ID));
                param.Add(new SPParameter("rolId", rol.ID));

                StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_InsertFuncionalidadXRol, param);
                sp.ExecuteNonQuery();
            }
        }

        public void DeleteByRol(Rol rol)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("rolId", rol.ID));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_DeleteAllFuncionalidadXRol);
            sp.ExecuteNonQuery();
        }
    }
}
