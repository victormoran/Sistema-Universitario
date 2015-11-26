using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Alumno
    {     
       public Alumno() { }
       public Alumno(int idAlumno, Perfil objPerfil, Escuela objEscuela) 
       {
           this.idAlumno = idAlumno;
           this.objPerfil = objPerfil;
           this.objEscuela = objEscuela;
       }
       private int idAlumno;

       public int IdAlumno
       {
           get { return idAlumno; }
           set { idAlumno = value; }
       }
       private Perfil objPerfil;

       public Perfil ObjPerfil
       {
           get { return objPerfil; }
           set { objPerfil = value; }
       }

       private Escuela objEscuela;

       public Escuela ObjEscuela
       {
           get { return objEscuela; }
           set { objEscuela = value; }
       }
    }
}
