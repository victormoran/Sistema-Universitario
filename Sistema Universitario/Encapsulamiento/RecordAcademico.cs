using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class RecordAcademico
    {
       public RecordAcademico() { }
       public RecordAcademico(int idRecordAcademico, Alumno objAlumno, Grupo objGrupo, short ponderado)
       {
           this.idRecordAcademico = idRecordAcademico;
           this.objAlumno = objAlumno;
           this.objGrupo = objGrupo;
           this.ponderado=ponderado;
       }
       private int idRecordAcademico;

       public int IdRecordAcademico
       {
           get { return idRecordAcademico; }
           set { idRecordAcademico = value; }
       }
       private Alumno objAlumno;

       public Alumno ObjAlumno
       {
           get { return objAlumno; }
           set { objAlumno = value; }
       }
       private Grupo objGrupo;

       public Grupo ObjGrupo
       {
           get { return objGrupo; }
           set { objGrupo = value; }
       }
       private short ponderado;

       public short Ponderado
       {
           get { return ponderado; }
           set { ponderado = value; }
       }
    }
}
