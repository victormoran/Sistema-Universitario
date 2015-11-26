using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Escuela
    {       
       public Escuela() { }
       public Escuela(int idEscuela, Facultad objFacultad, Coordinador objCoordinador, string nombre) 
       {
           this.idEscuela = idEscuela;
           this.objFacultad = objFacultad;
           this.objCoordinador = objCoordinador;
           this.nombre = nombre;
       }
       private int idEscuela;

       public int IdEscuela
       {
           get { return idEscuela; }
           set { idEscuela = value; }
       }
       private Facultad objFacultad;

       public Facultad ObjFacultad
       {
           get { return objFacultad; }
           set { objFacultad = value; }
       }
       private Coordinador objCoordinador;

       public Coordinador ObjCoordinador
       {
           get { return objCoordinador; }
           set { objCoordinador = value; }
       }
       private string nombre;

       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
    }
}
