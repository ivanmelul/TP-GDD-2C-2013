using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Persistance;

namespace Logic
{
    public class RolLogic
    {
        private FuncionalidadLogic funcionalidadLogic;
        private RolPersistance persistance;

        public RolLogic()
        {
            funcionalidadLogic = new FuncionalidadLogic();
            persistance = new RolPersistance();
        }

        public List<Rol> GetAll()
        {
            List<Rol> roles = persistance.GetAll(); 

            foreach (Rol rol in roles)
                rol.Funcionalidades = funcionalidadLogic.GetFuncionalidadesByRol(rol);

            return roles;
        }

        public List<Rol> GetRolesByUser(Usuario usuario)
        {
            List<Rol> roles = persistance.GetByUser(usuario); 

            if (roles == null)
                return null;

            foreach (Rol rol in roles)
                rol.Funcionalidades = funcionalidadLogic.GetFuncionalidadesByRol(rol);

            return roles;
        }

        public Rol GetRolByNombre(String nombre, bool habilitados)
        {
            Rol rol = persistance.GetByNombre(nombre, habilitados);

            if (rol != null)
                rol.Funcionalidades = funcionalidadLogic.GetFuncionalidadesByRol(rol);
            
            return rol;
        }

        public List<Rol> GetRolesByNombre(String nombre, bool habilitados)
        {
            List<Rol> roles = persistance.GetByNombreLike(nombre, habilitados);

            foreach (var rol in roles)
                rol.Funcionalidades = funcionalidadLogic.GetFuncionalidadesByRol(rol);
            
            return roles;
        }

        public bool Create(Rol nuevo)
        {
            try
            {
                nuevo = persistance.InsertRole(nuevo);

                funcionalidadLogic.InsertByRol(nuevo);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool Modify(Rol viejo, Rol nuevo)
        {
            try
            {
                persistance.UpdateRole(nuevo);

                funcionalidadLogic.UpdateByRol(nuevo);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool Delete(Rol rol)
        {
            try
            {
                rol.Habilitado = false;
                persistance.UpdateRole(rol);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

}
