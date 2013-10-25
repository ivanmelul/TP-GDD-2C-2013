using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Persistance.Entities;

namespace Persistance
{
    public class RolPersistance
    {
        public List<Rol> GetAll()
        {
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_GetAllRol);
            return sp.ExecuteReader<Rol>();
        }

        public List<Rol> GetByUser(Usuario usuario)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("userId", usuario.ID));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_GetAllRolByUser, param);
            return sp.ExecuteReader<Rol>();
        }

        public Rol GetByNombre(String nombre, bool habilitados)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("rolName", nombre));
            param.Add(new SPParameter("rolHabilitados", habilitados));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_GetAllRolByUser, param);

            List<Rol> roles = sp.ExecuteReader<Rol>();

            if (roles == null || roles.Count == 0)
                return null;

            return roles[0];
        }

        public List<Rol> GetByNombreLike(String nombre, bool habilitados)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("rolName", nombre));
            param.Add(new SPParameter("rolHabilitados", habilitados));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_GetAllRolByNameLike, param);
            return sp.ExecuteReader<Rol>();
        }

        public Rol InsertRol(Rol rol)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("rolName", rol.Name));
            param.Add(new SPParameter("rolHabilitado", rol.Habilitado));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_InsertRol, param);
            rol.ID = (int) sp.ExecuteScalar();
            return rol;
        }

        public void UpdateRol(Rol nuevo)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("rolId", nuevo.ID);
            parameters.Add("rolName", nuevo.Name);
            parameters.Add("rolHabilitado", nuevo.Habilitado);

            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("rolId", nuevo.ID));
            param.Add(new SPParameter("rolName", nuevo.Name));
            param.Add(new SPParameter("rolHabilitado", nuevo.Habilitado));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Rol.SP_UpdateRolById, param);
            sp.ExecuteNonQuery();
        }
    }
}
