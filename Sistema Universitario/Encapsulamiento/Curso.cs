using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Curso
    {
       public Curso() { }
       public Curso(int idCurso,string nombre) 
       {
           this.idCurso = idCurso;
           this.nombre = nombre;
       }
       private int idCurso;

       public int IdCurso
       {
           get { return idCurso; }
           set { idCurso = value; }
       }
       private string nombre;

       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
    }
}
