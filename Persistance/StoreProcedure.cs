using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Persistance.Entities;

namespace Persistance
{
    public class StoreProcedure
    {
        #region Fields

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private Dictionary<String, SPParameter> parameters;

        public Dictionary<String, SPParameter> Parameters
        {
            get { return parameters; }
        }

        private SqlTransaction transaction;

        public SqlTransaction Transaction
        {
            get { return transaction; }
        }

        private DataBaseManager dataBaseManager;

        #endregion

        public StoreProcedure()
        {
            Initialize(String.Empty, null, null);
        }

        public StoreProcedure(String SP_Name)
        {
            Initialize(SP_Name, null, null);
        }

        public StoreProcedure(String SP_Name, List<SPParameter> SP_Parameters)
        {
            Initialize(SP_Name, SP_Parameters, null);
        }

        public StoreProcedure(String SP_Name, List<SPParameter> SP_Parameters, SqlTransaction SP_Transaction)
        {
            Initialize(SP_Name, SP_Parameters, SP_Transaction);
        }

        private void Initialize(String SP_Name, List<SPParameter> SP_Parameters, SqlTransaction SP_Transaction)
        {
            // Set the Name
            if (String.IsNullOrEmpty(SP_Name))
                name = String.Empty;
            else
                name = SP_Name;

            // Set the Parameters
            if (SP_Parameters == null || SP_Parameters.Count == 0)
                parameters = new Dictionary<String, SPParameter>(0);
            else
            {
                try
                {
                    parameters = SP_Parameters.ToDictionary(p => p.Name, p => p);
                }
                catch (Exception e)
                {
                    throw new Exception("There are parameters with the same name.");
                }
            }

            // Set the Transaction
            transaction = SP_Transaction;

            // Set the Connection
            dataBaseManager = DataBaseManager.Instance();
        }

        public bool HasParameters
        {
            get { return parameters.Count > 0; }
        }

        public bool HasTransaction
        {
            get { return transaction != null; }
        }

        public int ExecuteNonQuery()
        {
            SqlConnection conn = dataBaseManager.Connection;

            try
            {
                SqlCommand cmd = new SqlCommand(name, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SPParameter parameter in parameters.Values)
                {
                    cmd.Parameters.Add(parameter);
                }

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*
         * ExecuteReader(): Return the SqlDataReader
         * Remember to close SqlDataReader after.
         */
        public SqlDataReader ExecuteReader()
        {
            SqlConnection conn = dataBaseManager.Connection;

            try
            {
                SqlCommand cmd = new SqlCommand(name, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SPParameter parameter in parameters.Values)
                {
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add(parameter.Parameter);
                }

                // Don't close the SqlDataReader
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*
         * ExecuteReader<T>(): Return the entities mapped
         */
        public List<T> ExecuteReader<T>()
            where T : IMapable, new()
        {
            try
            {
                // Execute the SP and get the SqlDataReader
                SqlDataReader reader = ExecuteReader();

                // Map the Entities
                List<T> map = new List<T>();

                while (reader.Read())
                {
                    T mapable = new T();
                    map.Add((T)mapable.Map(reader));
                }

                // Close the SqlDataReader
                if (!reader.IsClosed)
                    reader.Close();

                return map;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*
         * ExecuteReader(DelegateMap customMap): Return the entities with a custom Map
         */
        public delegate IMapable DelegateMap(SqlDataReader reader);

        public List<IMapable> ExecuteReader(DelegateMap customMap)
        {
            try
            {
                // Execute the SP and get the SqlDataReader
                SqlDataReader reader = ExecuteReader();

                // Map the Entities
                List<IMapable> map = new List<IMapable>();

                while (reader.Read())
                {
                    map.Add(customMap(reader));
                }

                // Close the SqlDataReader
                if (!reader.IsClosed)
                    reader.Close();

                return map;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Dictionary<String, Object> ExecuteOutput()
        {
            SqlConnection conn = dataBaseManager.Connection;

            try
            {
                SqlCommand cmd = new SqlCommand(name, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SPParameter parameter in parameters.Values)
                {
                    cmd.Parameters.Add(parameter.Parameter);
                }

                cmd.ExecuteNonQuery();

                return parameters.Values.Where(p => p.IsOutput || p.IsInputOutput).ToDictionary(p => p.Name, p => p.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Object ExecuteScalar()
        {
            SqlConnection conn = dataBaseManager.Connection;

            try
            {
                SqlCommand cmd = new SqlCommand(name, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SPParameter parameter in parameters.Values)
                {
                    cmd.Parameters.Add(parameter.Parameter);
                }

                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*
         * TODO: Query class
         */

        public void ExecuteSQLQuery(string query)
        {
            SqlConnection conn = dataBaseManager.Connection;

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // No se cierra el Reader
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ExecuteSQLQuery(string query, out SqlDataReader rdr)
        {
            rdr = null;

            SqlConnection conn = dataBaseManager.Connection;

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                rdr = cmd.ExecuteReader();
                // No se cierra el Reader
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
