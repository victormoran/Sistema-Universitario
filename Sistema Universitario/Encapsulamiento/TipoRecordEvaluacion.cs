using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class TipoRecordEvaluacion
    {
        public TipoRecordEvaluacion() { }
        public TipoRecordEvaluacion(int tipoRecordEvaluacion,string nombre)
        {
            this.tipoRecordEvaluacion = tipoRecordEvaluacion;
            this.nombre = nombre;

        }
        private int tipoRecordEvaluacion;

        public int TipoRecordEvaluacion1
        {
            get { return tipoRecordEvaluacion; }
            set { tipoRecordEvaluacion = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
