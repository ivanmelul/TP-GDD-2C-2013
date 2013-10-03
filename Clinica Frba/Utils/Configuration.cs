using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Globalization;

namespace Clinica_Frba.Utils
{
    public class Configuration
    {
        public static string GetConfigValue(String key)
        {
            try
            {
                return ConfigurationManager.AppSettings.Get(key);
            }
            catch
            {
                return null;
            }
        }

        public static DateTime SystemDate { get { return DateTime.Parse(GetConfigValue("systemDate"), CultureInfo.CurrentCulture); } }

        public static CultureInfo SystemCulture { get { return new CultureInfo(GetConfigValue("DefaultCulture")); } }

        public static string GetDBValue(String key)
        {
            try
            {
                return ConfigurationManager.ConnectionStrings[key].ConnectionString;
            }
            catch
            {
                return null;
            }
        }
    }
}
