using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;
using Persistance;

namespace Logic
{
    public class FuncionalidadLogic
    {
        private FuncionalidadPersistance persistance;

        public FuncionalidadLogic()
        {
            persistance = new FuncionalidadPersistance();
        }

        public List<Funcionalidad> GetAll()
        {
            return persistance.GetAll();
        }

        public List<Funcionalidad> GetFuncionalidadesByRol(Rol rol)
        {
            return persistance.GetByRol(rol);
        }

        public void InsertByRol(Rol rol) 
        {
            persistance.InsertByRol(rol);
        }

        public void UpdateByRol(Rol rol) {
            persistance.DeleteByRol(rol);

            persistance.InsertByRol(rol);
        }
    }
}
