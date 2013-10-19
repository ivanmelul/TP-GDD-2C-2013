using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;

namespace Persistance
{
    public class UsuarioPersistance
    {
        public void Update(Usuario user)
        {
            //Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            //parameters.Add("userId", user.ID);
            //parameters.Add("loginFails", user.LoginFails);
            //parameters.Add("habilitado", user.Habilitado ? 1 : 0);

            //StoreProcedure sp_UpdateUser = new StoreProcedure(DataBaseConst.Usuario.SP_UpdateUser, parameters);

            //sp_UpdateUser.Execute();
        }

        public Usuario GetUserByUsername(string userName)
        {
            return new Usuario();
            //Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            //parameters.Add("username", userName);

            //Usuario usuario = GetUserFromSP(DataBaseConst.Usuario.SP_GetUserByUsername, parameters);

            //if (usuario != null)
            //    usuario.Roles = new RolesLogic().GetRolesByUser(usuario, true);

            //return usuario;
        }

        public Usuario GetUserFromSP(string nameSP, Dictionary<string, object> parameters)
        {
            return new Usuario();
            //StoreProcedure sp = new StoreProcedure(nameSP, parameters);

            //Usuario usuario = new Usuario();
            //SqlDataReader reader = null;
            //sp.Execute(out reader);

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        usuario = MapToEntity(reader);
            //    }
            //    reader.Close();

            //    return usuario;
            //}
            //reader.Close();
            //return null;
        }

        public Usuario MapToEntity(SqlDataReader reader)
        {

            return new Usuario();
            //Usuario usuario = new Usuario();
            //usuario.ID = Int32.Parse(reader["Usuario_ID"].ToString());
            //usuario.Password = reader["Usuario_Password"].ToString();
            //usuario.Username = reader["Usuario_Nombre"].ToString();
            //usuario.Habilitado = bool.Parse(reader["Usuario_Habilitado"].ToString());
            //usuario.LoginFails = int.Parse(reader["Usuario_LoginFails"].ToString());

            //usuario.Roles = null;

            //return usuario;
        }

    }
}
