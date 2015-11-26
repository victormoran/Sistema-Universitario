using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class CursoPlanDeEstudios
    {      
        public CursoPlanDeEstudios() { }
        public CursoPlanDeEstudios(int idCursoPlanDeEstudios, Curso objCurso, PlanDeEstudios objPlanDeEstudios, string ciclo, byte creditos, byte horasDictadas) 
        {
            this.idCursoPlanDeEstudios = idCursoPlanDeEstudios;
            this.objCurso = objCurso;
            this.objPlanDeEstudios = objPlanDeEstudios;
            this.ciclo = ciclo;
            this.creditos = creditos;
            this.horasDictadas = horasDictadas;
        }
        private int idCursoPlanDeEstudios;

        public int IdCursoPlanDeEstudios
        {
            get { return idCursoPlanDeEstudios; }
            set { idCursoPlanDeEstudios = value; }
        }
        private Curso objCurso;

        public Curso ObjCurso
        {
            get { return objCurso; }
            set { objCurso = value; }
        }
        private PlanDeEstudios objPlanDeEstudios;

        public PlanDeEstudios ObjPlanDeEstudios
        {
            get { return objPlanDeEstudios; }
            set { objPlanDeEstudios = value; }
        }
        private string ciclo;

        public string Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }
        private byte creditos;

        public byte Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        private byte horasDictadas;

        public byte HorasDictadas
        {
            get { return horasDictadas; }
            set { horasDictadas = value; }
        }
    }
}
