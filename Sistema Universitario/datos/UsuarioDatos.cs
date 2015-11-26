using Datos;
using Encapsulamiento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class UsuarioDatos
    {
        public int VerificarUsuario(String usuario , String password)
        {
            List<DbParameter> parametros = new List<DbParameter>();
            DbParameter param;
            param = Conexion.FabricaMetodos.CreateParameter();
            int tipo=0;
            String StoredProcedure = "VerificarUsuario";
            using (DbConnection con = Conexion.FabricaMetodos.CreateConnection())
            {
                con.ConnectionString = Conexion.CadenaConexion;
                using (DbCommand cmd = Conexion.FabricaMetodos.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    param.Value = usuario;
                    param.ParameterName = "@usuario";
                    cmd.Parameters.Add(param);
                    param = null;
                    param = Conexion.FabricaMetodos.CreateParameter();
                    param.Value = password;
                    param.ParameterName = "@password";
                    cmd.Parameters.Add(param);
                    param = null;
                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tipo = (byte)dr["tipo"];
                        }
                    }
                }
            }
            return tipo;
        }
    }
}
