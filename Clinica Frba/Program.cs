using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;
using Persistance;

namespace Clinica_Frba
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeConfig();

            // Primer Form
            Application.Run(new Login.frmLogin());
        }

        public static void InitializeConfig()
        {
            // Seteo la Conexion a la Base
            DataBaseManager.ConnectionString = Utils.Configuration.GetDBValue("dataSource");

            // Seteo el Culture de las Fechas y demas
            Application.CurrentCulture = Utils.Configuration.SystemCulture;
        }
    }
}
