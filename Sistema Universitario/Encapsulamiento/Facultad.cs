using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Facultad
    {
       public Facultad() { }
       public Facultad(int idFacultad,string nombre)
       {
           this.idFacultad = idFacultad;
           this.nombre = nombre;

       }
       private int idFacultad;

       public int IdFacultad
       {
           get { return idFacultad; }
           set { idFacultad = value; }
       }
       private string nombre;

       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }

    }
}
