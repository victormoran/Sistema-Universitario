using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Coordinador
    {      
       public Coordinador(){}
       public Coordinador(int idCoordinador, Perfil objPerfil)
       {
           this.idCoordinador = idCoordinador;
           this.objPerfil = objPerfil;

       }
       private int idCoordinador;

       public int IdCoordinador
       {
           get { return idCoordinador; }
           set { idCoordinador = value; }
       }
       private Perfil objPerfil;

       public Perfil ObjPerfil
       {
           get { return objPerfil; }
           set { objPerfil = value; }
       }
    }
}
