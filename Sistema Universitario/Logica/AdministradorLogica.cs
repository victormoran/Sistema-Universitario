using datos;
using Encapsulamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class AdministradorLogica
    {
       AdministradorDatos administradorDatos;
       Administrador administrador;
       Alumno alumno;
       Coordinador coordinador;
       Profesor profesor;
       public Administrador MostrarAdministrador(String usuario) 
       {
           administradorDatos = new AdministradorDatos();
           administrador = new Administrador();
           administrador = administradorDatos.MostrarAdministrador(usuario);
           return administrador;
       }

       public Alumno MostrartodosAlumnos() 
       {
           administradorDatos = new AdministradorDatos();
           alumno = new Alumno();
           alumno = administradorDatos.MostrarTodosAlumnos();
           return alumno;
       }

       public Coordinador MostrartodosCoordinadores()
       {
           administradorDatos = new AdministradorDatos();
           coordinador = new Coordinador();
           coordinador = administradorDatos.MostrarTodosCoordinadores();
           return coordinador;
       }

       public Profesor MostrartodosProfesores()
       {
           administradorDatos = new AdministradorDatos();
           profesor = new Profesor();
           profesor = administradorDatos.MostrarTodosProfesores();
           return profesor;
       }
    }
}
