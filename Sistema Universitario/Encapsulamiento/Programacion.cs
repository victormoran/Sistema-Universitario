using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Programacion
    {
       public Programacion() { }
       public Programacion(int idProgramacion, Semestre objSemestre, CursoPlanDeEstudios objCursoPlanDeEstudios, Profesor objProfesor) 
       {
           this.idProgramacion = idProgramacion;
           this.objSemestre = objSemestre;
           this.objCursoPlanDeEstudios=objCursoPlanDeEstudios;
           this.objProfesor=objProfesor;
       }
       private int idProgramacion;

       public int IdProgramacion
       {
           get { return idProgramacion; }
           set { idProgramacion = value; }
       }
       private Semestre objSemestre;

       public Semestre ObjSemestre
       {
           get { return objSemestre; }
           set { objSemestre = value; }
       }
       private CursoPlanDeEstudios objCursoPlanDeEstudios;

       public CursoPlanDeEstudios ObjCursoPlanDeEstudios
       {
           get { return objCursoPlanDeEstudios; }
           set { objCursoPlanDeEstudios = value; }
       }
       private Profesor objProfesor;

       public Profesor ObjProfesor
       {
           get { return objProfesor; }
           set { objProfesor = value; }
       }
    }
}
