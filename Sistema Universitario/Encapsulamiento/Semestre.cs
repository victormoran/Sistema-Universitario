using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Semestre
    {
        public Semestre() { }
        public Semestre(int idSemestre,DateTime fechaInicio,DateTime fechaFin) 
        {
            this.idSemestre = idSemestre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;

        }
        private int idSemestre;

        public int IdSemestre
        {
            get { return idSemestre; }
            set { idSemestre = value; }
        }
        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
    }
}
