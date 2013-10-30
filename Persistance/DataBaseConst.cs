using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance
{
    public static class DataBaseConst
    {
        public static class Funcionalidad
        {
            public static String SP_GetAllFuncionalidad = "SQUELA.GetAllFuncionalidad";
            public static String SP_GetAllFuncionalidadByRol = "SQUELA.GetAllFuncionalidadByRol";
        }

        public static class Rol
        {
            public static String SP_GetAllRol = "SQUELA.GetAllRol";
            public static String SP_GetRolByName = "SQUELA.GetRolByName";
            public static String SP_GetAllRolByUser = "SQUELA.GetAllRolByUser";
            public static String SP_GetAllRolByNameLike = "SQUELA.GetAllRolByNameLike";
            public static String SP_InsertRol = "SQUELA.InsertRol";
            public static String SP_InsertFuncionalidadXRol = "SQUELA.InsertFuncionalidadXRol";
            public static String SP_DeleteFuncionalidadXRol = "SQUELA.DeleteFuncionalidadXRol";
            public static String SP_UpdateRolById = "SQUELA.UpdateRolById";
            public static String SP_DeleteAllFuncionalidadXRol = "SQUELA.DeleteAllFuncionalidadXRol";
        }

        public static class Usuario
        {
            public static String SP_GetUserByUsername = "SQUELA.GetUserByUsername";
            public static String SP_UpdateUser = "SQUELA.UpdateUser";
        }

        public static class Especialidad
        {
            public static String SP_GetAllEspecialidadByProfesional = "SQUELA.GetAllEspecialidadByProfesiona";
        }

        public static class TipoDocumento
        {
            public static String SP_GetAllTipoDocumento = "SQUELA.GetAllTipoDocumento";
        }
    }
}
