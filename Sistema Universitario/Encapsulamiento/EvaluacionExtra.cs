using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class EvaluacionExtra
    {       
       public EvaluacionExtra() { }
       public EvaluacionExtra(int idEvaluacionExtra, RegistroGrupo objRegistroGrupo, short notas) 
       {
           this.idEvaluacionExtra = idEvaluacionExtra;
           this.objRegistroGrupo = objRegistroGrupo;
           this.notas = notas;
       }
       private int idEvaluacionExtra;

       public int IdEvaluacionExtra
       {
           get { return idEvaluacionExtra; }
           set { idEvaluacionExtra = value; }
       }
       private RegistroGrupo objRegistroGrupo;

       public RegistroGrupo ObjRegistroGrupo
       {
           get { return objRegistroGrupo; }
           set { objRegistroGrupo = value; }
       }
       private short notas;

       public short Notas
       {
           get { return notas; }
           set { notas = value; }
       }
    }
}
