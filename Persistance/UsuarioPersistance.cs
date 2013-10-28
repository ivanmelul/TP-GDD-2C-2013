using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;
using System.Data.SqlClient;

namespace Persistance
{
    public class UsuarioPersistance
    {
        public Usuario GetUserByUsername(string userName)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("userName", userName));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Usuario.SP_GetUserByUsername, param);

            List<Usuario> usuarios = sp.ExecuteReader<Usuario>();

            if (usuarios == null || usuarios.Count == 0)
                return null;

            return usuarios[0];
        }

        public void Update(Usuario user)
        {
            List<SPParameter> param = new List<SPParameter>();
            param.Add(new SPParameter("userId", user.ID));
            param.Add(new SPParameter("userLoginFails", user.LoginFails));
            param.Add(new SPParameter("userHabilitado", user.Habilitado));
            StoreProcedure sp = new StoreProcedure(DataBaseConst.Usuario.SP_UpdateUser, param);
            sp.ExecuteNonQuery();
        }
    }
}
