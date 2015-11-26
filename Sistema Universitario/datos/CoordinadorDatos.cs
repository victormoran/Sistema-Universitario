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
    public class CoordinadorDatos
    {
        private Coordinador coordinador;

        public Coordinador MostrarCoordinador(String usuario )
        {
            List<DbParameter> parametros = new List<DbParameter>();
            DbParameter param;
            param = Conexion.FabricaMetodos.CreateParameter();
            Coordinador coordinador = new Coordinador();
            String StoredProcedure = "ListarPGenerales";
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
                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Perfil perfil=new Perfil();
                            Persona persona=new Persona();
                            persona.Dni=(String)dr[0];
                            persona.Nombre=(String)dr[1];
                            persona.Apellidos=(String)dr[2];
                            persona.Email=(String)dr[3];
                            persona.Telefono=(String)dr[4];
                            persona.Sexo=(bool)dr[5];
                            persona.Direccion=(String)dr[6];                            
                            persona.EstadoCivil=(Boolean)dr[7];
                            persona.FechaNacimiento=(DateTime)dr[8];
                            perfil.ObjPersona =persona;
                            coordinador.ObjPerfil = perfil;
                        }
                    }
                }
            }
            return coordinador;
        }
    }
    }

