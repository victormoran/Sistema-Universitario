using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class FechaEvaluacion
    {      
        public FechaEvaluacion() { }
        public FechaEvaluacion(int idFechaDeEvalucion, Grupo objGrupo, DateTime fechaPractica1, DateTime fechaPractica2, DateTime fechaParcial, DateTime fechaFinal, DateTime fechaExamenSustitutorio)
        {
            this.idFechaDeEvalucion = idFechaDeEvalucion;
            this.objGrupo = objGrupo;
            this.fechaPractica1 = fechaPractica1;
            this.fechaPractica2 = fechaPractica2;
            this.fechaParcial = fechaParcial;
            this.fechaFinal = fechaFinal;
            this.fechaExamenSustitutorio = fechaExamenSustitutorio;
        }
        private int idFechaDeEvalucion;

        public int IdFechaDeEvalucion
        {
            get { return idFechaDeEvalucion; }
            set { idFechaDeEvalucion = value; }
        }
        private Grupo objGrupo;

        public Grupo ObjGrupo
        {
            get { return objGrupo; }
            set { objGrupo = value; }
        }
        private DateTime fechaPractica1;

        public DateTime FechaPractica1
        {
            get { return fechaPractica1; }
            set { fechaPractica1 = value; }
        }
        private DateTime fechaPractica2;

        public DateTime FechaPractica2
        {
            get { return fechaPractica2; }
            set { fechaPractica2 = value; }
        }
        private DateTime fechaParcial;

        public DateTime FechaParcial
        {
            get { return fechaParcial; }
            set { fechaParcial = value; }
        }
        private DateTime fechaFinal;

        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }
        private DateTime fechaExamenSustitutorio;

        public DateTime FechaExamenSustitutorio
        {
            get { return fechaExamenSustitutorio; }
            set { fechaExamenSustitutorio = value; }
        }
    }
}
