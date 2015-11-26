using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Matricula
    {
       public Matricula() { }
       public Matricula(int idMatricula, Alumno objAlumno, Semestre objSemestre, DateTime fecha) 
       {
           this.idMatricula = idMatricula;
           this.objAlumno = objAlumno;
           this.objSemestre = objSemestre;
         
           this.fecha = fecha;
       }
       private int idMatricula;

       public int IdMatricula
       {
           get { return idMatricula; }
           set { idMatricula = value; }
       }
       private Alumno objAlumno;

       public Alumno ObjAlumno
       {
           get { return objAlumno; }
           set { objAlumno = value; }
       }
       private Semestre objSemestre;

       public Semestre ObjSemestre
       {
           get { return objSemestre; }
           set { objSemestre = value; }
       }
       
       private DateTime fecha;

       public DateTime Fecha
       {
           get { return fecha; }
           set { fecha = value; }
       }
    }
}
