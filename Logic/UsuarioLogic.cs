using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance.Entities;
using Persistance;
using System.Security.Cryptography;

namespace Logic
{
    public class UsuarioLogic
    {
        private UsuarioPersistance persistance;

        public UsuarioLogic() {
            persistance = new UsuarioPersistance();
        }

        public Usuario Login(string userName, string password)
        {

            Usuario usuario = persistance.GetUserByUsername(userName);

            if (usuario == null)
                throw new Exception("El nombre de usuario ingresado no existe.");

            if (!usuario.Habilitado)
                throw new Exception("El usuario ingresado se encuentra deshabilitado.");

            HashAlgorithm algorithm = new SHA256CryptoServiceProvider();
            Byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            string hashed = BitConverter.ToString(hashedBytes);

            if (usuario.Password != hashed)
            {
                usuario.LoginFails += 1;
                usuario.Habilitado = usuario.LoginFails >= 3 ? false : true;

                persistance.Update(usuario);

                throw new Exception("La contraseña ingresada no es valida.");
            }

            bool rolesHabilitados = false;

            foreach (var rol in usuario.Roles)
            {
                if (rol.Habilitado)
                    rolesHabilitados = true;
            }

            if (!rolesHabilitados)
                throw new Exception("No cuenta con un rol habilitado, por lo que no puede ingresar al sistema.");

            usuario.LoginFails = 0;
            persistance.Update(usuario);

            return usuario;
        }


    }
}
