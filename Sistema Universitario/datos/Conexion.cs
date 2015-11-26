using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Datos
{
    class Conexion
    {
        public static String CadenaConexion
        {
            get { return ConfigurationManager.ConnectionStrings["SistemaUniversitario"].ConnectionString; }
        }
        public static String Provider
        {
            get { return ConfigurationManager.ConnectionStrings["SistemaUniversitario"].ProviderName; }
        }
        public static DbProviderFactory FabricaMetodos
        {
            get { return DbProviderFactories.GetFactory(Provider); }
        }
    }
}
