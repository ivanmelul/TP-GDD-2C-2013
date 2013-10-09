using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;

namespace Persistance
{
    public class RolPersistance
    {
        public Rol MapToEntity(SqlDataReader reader)
        {
            Rol rol = new Rol();
            rol.ID = Int32.Parse(reader["Rol_ID"].ToString());
            rol.Name = ((String)reader["Rol_Nombre"]).Trim();
            rol.Habilitado = bool.Parse(reader["Rol_Habilitado"].ToString());
            rol.Funcionalidades = null;
            return rol;
        }

        public List<Rol> GetRolesFromSP(String nameSP, Dictionary<String, Object> parameters)
        {
            return new List<Rol>();
            //StoreProcedure sp = new StoreProcedure(nameSP, parameters);

            //List<Rol> rol = new List<Rol>();
            //SqlDataReader reader = null;
            //sp.Execute(out reader);

            //while (reader.Read())
            //{
            //    rol.Add(MapToEntity(reader));
            //}
            //reader.Close();

            //return rol;

        }

        private List<Rol> GetRolesFromSP(String nameSP)
        {
            return GetRolesFromSP(nameSP, null);
        }

        public List<Rol> GetAll() {
            return GetRolesFromSP(DataBaseConst.Rol.SP_GetAllRol);
        }

        public List<Rol> GetByUser(Usuario usuario)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("userId", usuario.ID);

            return GetRolesFromSP(DataBaseConst.Rol.SP_GetRolesByUser, parameters);
        }

        public Rol GetByNombre(String nombre, bool habilitados)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("roleName", nombre);
            parameters.Add("habilitados", habilitados);

            List<Rol> roles = GetRolesFromSP(DataBaseConst.Rol.SP_GetRolByName, parameters);

            if (roles == null || roles.Count == 0)
                return null;

            return roles[0];
        }

        public List<Rol> GetByNombreLike(String nombre, bool habilitados)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("roleName", nombre);
            parameters.Add("habilitados", habilitados);

            List<Rol> roles = GetRolesFromSP(DataBaseConst.Rol.SP_GetRolByNameLike, parameters);

            return roles;
        }

        public Rol InsertRole(Rol rol)
        {
            //Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            //parameters.Add("roleName", rol.Name);
            //parameters.Add("habilitado", rol.Habilitado);

            //// Creo el SP del Rol y lo ejecuto
            //StoreProcedure sp_InsertRole = new StoreProcedure(DataBaseConst.Rol.SP_InsertRole, parameters);
            //SqlDataReader reader;
            //sp_InsertRole.Execute(out reader);

            //while (reader.Read())
            //{
            //    rol.ID = int.Parse(reader[0].ToString());
            //}
            //reader.Close();

            return rol;
        }

        public void UpdateRole(Rol nuevo)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("id", nuevo.ID);
            parameters.Add("roleName", nuevo.Name);
            parameters.Add("habilitado", nuevo.Habilitado);

            //StoreProcedure sp_UpdateRole = new StoreProcedure(DataBaseConst.Rol.SP_UpdateRoleById, parameters);
            //sp_UpdateRole.Execute();
        }
    }
}
