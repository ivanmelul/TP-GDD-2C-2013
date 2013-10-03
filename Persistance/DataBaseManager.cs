using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Persistance
{
    public class DataBaseManager
    {
        private SqlConnection connection;

        public SqlConnection Connection
        {
            get 
            {
                if (connection.State != ConnectionState.Open)
                    OpenConnection();

                return connection;
            }
        }

        /*
         * Constructor private -> Singleton.
         * Se instancia solo una vez, para mantener siempre la misma conexion a la DB.
         */
        private DataBaseManager()
        {
            OpenConnection();
        }

        private void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error iniciando la conexion con la DB.");
            }
        }

        private static DataBaseManager _dataBaseManager;

        public static DataBaseManager Instance()
        {
            if (_dataBaseManager == null)
            {
                _dataBaseManager = new DataBaseManager();
            }

            return _dataBaseManager;
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public static String ConnectionString { get; set; }
    }
}
