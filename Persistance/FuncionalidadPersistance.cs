using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;

namespace Persistance
{
    public class FuncionalidadPersistance
    {
        public Funcionalidad MapToEntity(SqlDataReader reader)
        {
            Funcionalidad func = new Funcionalidad();
            func.ID = int.Parse(reader["Func_ID"].ToString());
            func.Name = reader["Func_Nombre"].ToString();
            return func;
        }

        private List<Funcionalidad> GetFuncionalidadesFromSP(String nameSP)
        {
            return GetFuncionalidadesFromSP(nameSP, null);
        }

        private List<Funcionalidad> GetFuncionalidadesFromSP(String nameSP, Dictionary<String, Object> param)
        {
            return new List<Funcionalidad>();
            //StoreProcedure sp = new StoreProcedure(nameSP, param);

            //List<Funcionalidad> func = new List<Funcionalidad>();
            //SqlDataReader reader = null;
            //sp.Execute(out reader);

            //while (reader.Read())
            //{
            //    func.Add(MapToEntity(reader));
            //}
            //reader.Close();

            //return func;
        }

        public List<Funcionalidad> GetAll()
        {
            return GetFuncionalidadesFromSP(DataBaseConst.Funcionalidad.SP_GetAllFuncionalidades);
        }

        public List<Funcionalidad> GetByRol(Rol rol)
        {
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("id", rol.ID);
            return GetFuncionalidadesFromSP(DataBaseConst.Funcionalidad.SP_GetFuncionalidadesByRol, param);
        }

        public void InsertByRol(Rol rol)
        {
            // Creo los SP de las Funcionalidades del Rol y los ejecuto
            //List<StoreProcedure> sp_funcs = new List<StoreProcedure>();

            //foreach (Funcionalidad func in rol.Funcionalidades)
            //{
            //    Dictionary<String, Object> parametersFunc = new Dictionary<String, Object>();
            //    parametersFunc.Add("idFunc", func.ID);
            //    parametersFunc.Add("idRol", rol.ID);

            //    StoreProcedure sp_InsertFunc = new StoreProcedure(DataBaseConst.Rol.SP_InsertFuncionalidadXRol, parametersFunc);
            //    sp_InsertFunc.Execute();
            //}
        }

        public void DeleteByRol(Rol rol)
        {
            // Elimino todas las Funcionalidades del Rol
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("idRol", rol.ID);

            //new StoreProcedure(DataBaseConst.Rol.SP_DeleteAllFuncionalidadXRol, parameters).Execute();
        }
    }
}
