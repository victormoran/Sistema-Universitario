using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Perfil
    {
       public Perfil() {}
       public Perfil(int idPerfil, Persona objPersona, String tipo) 
       {
           this.idPerfil = idPerfil;
           this.objPersona = objPersona;
           this.tipo = tipo;
       }
       private int idPerfil;

       public int IdPerfil
       {
           get { return idPerfil; }
           set { idPerfil = value; }
       }
       private Persona objPersona;

       public Persona ObjPersona
       {
           get { return objPersona; }
           set { objPersona = value; }
       }
       private string tipo;

       public string Tipo
       {
           get { return tipo; }
           set { tipo = value; }
       }


    }
}
