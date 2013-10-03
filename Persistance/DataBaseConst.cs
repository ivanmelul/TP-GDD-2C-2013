using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance
{
    public static class DataBaseConst
    {
        public static class Productos
        {
            public static String SP_GetAvailableByCliente = "GESTIONAMESQLO.[GetAvailableProductosByPuntos]";
        }

        public static class Reportes
        {
            public static String SP_GetPuntosByCliente = "GESTIONAMESQLO.GetPuntosByCliente";
            public static String SP_GetDetallePuntosByCliente = "GESTIONAMESQLO.[GetDetallePuntosAcumuladosByCliente]";
            public static String SP_GetDestinosMasComprados = "GESTIONAMESQLO.GetTop5MasDestinosConPasajesComprados";
            public static String SP_GetDestinosMasCancelados = "GESTIONAMESQLO.GetTop5MasDestinosConPasajesCancelados";
            public static String SP_GetMicrosFueraDeServicio = "GESTIONAMESQLO.GetTop5MicrosFueraDeServicio";
            public static String SP_GetMicrosMasVacios = "GESTIONAMESQLO.GetTop5DestinosMicrosMasVacios";
            public static String SP_GetClientesMasPuntos = "GESTIONAMESQLO.GetTop5ClientesMasPuntos";
        }

        public static class Ciudad
        {
            public static String SP_GetAllCiudad = "GESTIONAMESQLO.GetAllCiudad";
        }

        public static class Pasaje
        {
            public static String SP_GetPasajeByRecorrido = "GESTIONAMESQLO.GetPasajeByRecorrido";
            public static String SP_GetPasajeByCompra = "GESTIONAMESQLO.GetPasajeByCompra";
            public static String SP_GetPasajeByViaje = "GESTIONAMESQLO.GetPasajeByViaje";
            public static String SP_GetNoCanjeadosByDNI = "GESTIONAMESQLO.GetPasajesNoCanjeadosByDNI";
            public static String SP_CancelarPasaje = "GESTIONAMESQLO.CancelarPasaje";
            public static String SP_CancelarPasajeWithIdDevolucion = "GESTIONAMESQLO.CancelarPasajeWithIdDevolucion";
            public static String SP_InsertPasaje = "GESTIONAMESQLO.InsertPasaje";
            public static String SP_GetPasajeByPersonaAndViaje = "GESTIONAMESQLO.GetPasajeByPersonaAndViaje";
            public static String SP_GetNewPasajeID = "GESTIONAMESQLO.GetNewPasajeID";
        }

        public static class Funcionalidad
        {
            public static String SP_GetAllFuncionalidades = "GESTIONAMESQLO.GetAllFuncionalidades";
            public static String SP_GetFuncionalidadesByRol = "GESTIONAMESQLO.GetFuncionalidadesByRol";
        }

        public static class Marca
        {
            public static String SP_GetAllMarca = "GESTIONAMESQLO.GetAllMarca";
        }

        public static class Micro
        {
            public static String SP_GetMicroByFechasAndPatente = "GESTIONAMESQLO.GetMicroByFechasAndPatente";
            public static String SP_GetMicroByMarcaAndTipoServicio = "GESTIONAMESQLO.GetMicroByMarcaAndTipoServicio";
            public static String SP_GetMicroByPatenteLike = "GESTIONAMESQLO.GetMicroByPatenteLike";
            public static String SP_GetMicroByPatente = "GESTIONAMESQLO.GetMicroByPatente";
            public static String SP_InsertMicro = "GESTIONAMESQLO.InsertMicro";
            public static String SP_UpdateMicro = "GESTIONAMESQLO.UpdateMicro";
            public static String SP_BajaUtil = "GESTIONAMESQLO.SetMicroBajaUtil";
            public static String SP_GetMicrosAvailable = "GESTIONAMESQLO.GetMicrosAvailableByFechaServicioAndMarca";
        }

        public static class Butaca
        {
            public static String SP_GetAllButacaByMicro = "GESTIONAMESQLO.GetAllButacaByMicro";
            public static String SP_InsertButacaByMicro = "GESTIONAMESQLO.InsertButacaByMicro";
            public static String SP_DeleteAllButacaByMicro = "GESTIONAMESQLO.DeleteAllButacaByMicro";
            public static String SP_GetFreeButacaByViaje = "GESTIONAMESQLO.GetFreeButacaByViaje";
        }

        public static class Recorrido
        {
            public static String SP_GetAllRecorrido = "GESTIONAMESQLO.GetAllRecorrido";
            public static String SP_GetRecorridoById = "GESTIONAMESQLO.GetRecorridoById";
            public static String SP_GetRecorridoByIdLike = "GESTIONAMESQLO.GetRecorridoByIdLike";
            public static String SP_GetRecorridoByCiudadOServicio = "GESTIONAMESQLO.GetRecorridoByCiudadOServicio";
            public static String SP_InsertRecorrido = "GESTIONAMESQLO.InsertRecorrido";
            public static String SP_UpdateRecorrido = "GESTIONAMESQLO.UpdateRecorrido";
            public static String SP_DeleteRecorridoById = "GESTIONAMESQLO.DeleteRecorridoById";
        }

        public static class Rol
        {
            public static String SP_GetAllRol = "GESTIONAMESQLO.GetAllRol";
            public static String SP_GetRolByName = "GESTIONAMESQLO.GetRoleByName";
            public static String SP_GetRolesByUser = "GESTIONAMESQLO.GetRolesByUser";
            public static String SP_GetRolByNameLike = "GESTIONAMESQLO.GetRoleByNameLike";
            public static String SP_InsertRole = "GESTIONAMESQLO.InsertRole";
            public static String SP_InsertFuncionalidadXRol = "GESTIONAMESQLO.InsertFuncionalidadXRol";
            public static String SP_DeleteFuncionalidadXRol = "GESTIONAMESQLO.DeleteFuncionalidadXRol";
            public static String SP_UpdateRoleById = "GESTIONAMESQLO.UpdateRoleById";
            public static String SP_DeleteAllFuncionalidadXRol = "GESTIONAMESQLO.DeleteAllFuncionalidadXRol";
        }

        public static class TipoServicio
        {
            public static String SP_GetAllTipoServicio = "GESTIONAMESQLO.GetAllTipoServicio";
        }

        public static class Viajes
        {
            public static String SP_GetAllViaje = "GESTIONAMESQLO.GetAllViaje";
            public static String SP_GetViajeBy = "GESTIONAMESQLO.GetViajeBy";
            public static String SP_GetViajeByFechaAndCiudad = "GESTIONAMESQLO.GetViajeByFechaAndCiudad";
            public static String SP_UpdateViaje = "GESTIONAMESQLO.UpdateViaje";
            public static String SP_UpdateViajeForMicro = "GESTIONAMESQLO.UpdateViajeForMicro";
            public static String SP_InsertViaje = "GESTIONAMESQLO.InsertViaje";
            public static String SP_GetViajeAvailability = "GESTIONAMESQLO.GetViajeAvailability";
            public static String SP_GetViajeKGAvailability = "GESTIONAMESQLO.GetViajeKGAvailability";
            public static String SP_GetViajeByMicroAndFecha = "GESTIONAMESQLO.GetViajeByMicroAndFecha";
            public static String SP_GetViajesByMicroCiudadesAndFecha = "GESTIONAMESQLO.GetViajesByMicroCiudadesAndFecha";
            public static String SP_GetViajeByMicroAndFechas = "GESTIONAMESQLO.GetViajesByMicroAndFechas";
            public static String SP_GetViajeByFechaAndPersona = "GESTIONAMESQLO.GetViajeByFechaAndPersona";
        }

        public static class Persona
        {
            public static String SP_GetPersonaByDNI = "GESTIONAMESQLO.GetPersonaByDNI";
            public static String SP_GetPersonaByViaje = "GESTIONAMESQLO.GetPersonaByViaje";
            public static String SP_InsertPersona = "GESTIONAMESQLO.InsertPersona";
            public static String SP_UpdatePersona = "GESTIONAMESQLO.UpdatePersona";
        }

        public static class Usuario
        {
            public static String SP_GetUserByUsername = "GESTIONAMESQLO.GetUserByUsername";
            public static String SP_UpdateUser = "GESTIONAMESQLO.UpdateUser";
        }

        public static class Compra
        {
            public static String SP_InsertCompra = "GESTIONAMESQLO.InsertCompra";
            public static String SP_GetCompraIDByFechaCompraAndCliente = "GESTIONAMESQLO.GetCompraIDByFechaCompraAndCliente";
            public static String SP_InsertCompraXPasaje = "GESTIONAMESQLO.InsertCompraXPasaje";
        }
    }
}
