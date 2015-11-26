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
   public  class AdministradorDatos
    {
       private Administrador administrador;
       private Alumno alumno;
       private Coordinador coordinador;
       private Profesor profesor;

       public Administrador MostrarAdministrador(String usuario)
        {
            List<DbParameter> parametros = new List<DbParameter>();
            DbParameter param;
            param = Conexion.FabricaMetodos.CreateParameter();
            Administrador administrador = new Administrador();
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
                            Perfil perfil = new Perfil();
                            Persona persona = new Persona();
                            persona.Dni = (String)dr[0];
                            persona.Nombre = (String)dr[1];
                            persona.Apellidos = (String)dr[2];
                            persona.Email = (String)dr[3];
                            persona.Telefono = (String)dr[4];
                            persona.Sexo = (bool)dr[5];
                            persona.Direccion = (String)dr[6];                            
                            persona.EstadoCivil = (Boolean)dr[7];
                            persona.FechaNacimiento = (DateTime)dr[8];
                            perfil.ObjPersona = persona;
                            administrador.ObjPerfil = perfil;
                        }
                    }
                }
            }
            return administrador;
        }
       public Alumno MostrarTodosAlumnos()
       {
           List<DbParameter> parametros = new List<DbParameter>();
           DbParameter param;
           param = Conexion.FabricaMetodos.CreateParameter();
           String StoredProcedure = "ListarTodosAlumnos";
           using (DbConnection con = Conexion.FabricaMetodos.CreateConnection())
           {
               con.ConnectionString = Conexion.CadenaConexion;
               using (DbCommand cmd = Conexion.FabricaMetodos.CreateCommand())
               {
                   cmd.Connection = con;
                   cmd.CommandText = StoredProcedure;
                   cmd.CommandType = CommandType.StoredProcedure;
                   con.Open();
                   using (DbDataReader dr = cmd.ExecuteReader())
                   {
                       while (dr.Read())
                       {
                           Perfil perfil = new Perfil();
                           Persona persona = new Persona();
                           Escuela escuela = new Escuela();
                           persona.Dni = (String)dr[0];
                           persona.Nombre = (String)dr[1];
                           persona.Apellidos = (String)dr[2];
                           escuela.Nombre = (String)dr[3];
                           perfil.ObjPersona = persona;
                           alumno.ObjPerfil = perfil;

                       }
                   }
               }
           }
           return alumno;
       }

       public Coordinador MostrarTodosCoordinadores()
       {
           List<DbParameter> parametros = new List<DbParameter>();
           DbParameter param;
           param = Conexion.FabricaMetodos.CreateParameter();
           String StoredProcedure = "ListarTodosCoordinadores";
           using (DbConnection con = Conexion.FabricaMetodos.CreateConnection())
           {
               con.ConnectionString = Conexion.CadenaConexion;
               using (DbCommand cmd = Conexion.FabricaMetodos.CreateCommand())
               {
                   cmd.Connection = con;
                   cmd.CommandText = StoredProcedure;
                   cmd.CommandType = CommandType.StoredProcedure;
                   con.Open();
                   using (DbDataReader dr = cmd.ExecuteReader())
                   {
                       while (dr.Read())
                       {
                           Perfil perfil = new Perfil();
                           Persona persona = new Persona();                           
                           persona.Dni = (String)dr[0];
                           persona.Nombre = (String)dr[1];
                           persona.Apellidos = (String)dr[2];                           
                           perfil.ObjPersona = persona;
                           coordinador.ObjPerfil = perfil;

                       }
                   }
               }
           }
           return coordinador;
       }

          public Profesor MostrarTodosProfesores()
       {
           List<DbParameter> parametros = new List<DbParameter>();
           DbParameter param;
           param = Conexion.FabricaMetodos.CreateParameter();
           String StoredProcedure = "ListarTodosProfesores";
           using (DbConnection con = Conexion.FabricaMetodos.CreateConnection())
           {
               con.ConnectionString = Conexion.CadenaConexion;
               using (DbCommand cmd = Conexion.FabricaMetodos.CreateCommand())
               {
                   cmd.Connection = con;
                   cmd.CommandText = StoredProcedure;
                   cmd.CommandType = CommandType.StoredProcedure;
                   con.Open();
                   using (DbDataReader dr = cmd.ExecuteReader())
                   {
                       while (dr.Read())
                       {
                           Perfil perfil = new Perfil();
                           Persona persona = new Persona();                           
                           persona.Dni = (String)dr[0];
                           persona.Nombre = (String)dr[1];
                           persona.Apellidos = (String)dr[2];                           
                           perfil.ObjPersona = persona;
                           profesor.ObjPerfil = perfil;

                       }
                   }
               }
           }
           return profesor;
       }

    }

    }

