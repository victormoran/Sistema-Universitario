using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Grupo
    {       
       public Grupo() { }
       public Grupo(int idGrupo, Programacion objProgramacion, string nombre) 
       {
           this.idGrupo = idGrupo;
           this.objProgramacion = objProgramacion;
           this.nombre = nombre;
           
       }
      private  int idGrupo;

    public int IdGrupo
    {
      get { return idGrupo; }
      set { idGrupo = value; }
    }
          private Programacion objProgramacion;

    public Programacion ObjProgramacion
    {
      get { return objProgramacion; }
      set { objProgramacion = value; }
    }
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
        }
}
