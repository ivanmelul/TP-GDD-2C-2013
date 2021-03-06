﻿using System;
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
            public static String SP_GetAllEspecialidadByProfesional = "SQUELA.GetAllEspecialidadByProfesional";
            public static string SP_GetAllEspecialidad = "SQUELA.GetAllEspecialidad";
        }

        public static class TipoDocumento
        {
            public static String SP_GetAllTipoDocumento = "SQUELA.GetAllTipoDocumento";
        }

        public static class EstadoCivil
        {
            public static String SP_GetAllEstadoCivil = "SQUELA.GetAllEstadoCivil";
        }

        public static class PlanMedico
        {
            public static String SP_GetAllPlanMedico = "SQUELA.GetAllPlanMedico";
        }

        public static class Agenda {
            public static String SP_GetAllHorarioByAgendaId = "SQUELA.SP_GetAllHorarioByAgendaId";
        }

        public static class Afiliado
        {
            public static String SP_GetAfiliadoByDocumento = "SQUELA.GetAfiliadoByDocumento";
        }

        public static class Profesional
        {
            public static String SP_GetProfesionalByDocumento = "SQUELA.GetProfesionalByDocumento";
        }
    }
}
