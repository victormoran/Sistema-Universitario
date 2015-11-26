using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class RecordEvaluacion
    {
        public RecordEvaluacion() { }
        public RecordEvaluacion(int idRecordEvaluacion, TipoRecordEvaluacion objTipoRecordEvaluacion, RecordEvaluacion objRecordAcademico, short nota)
        {
            this.idRecordEvaluacion = idRecordEvaluacion;
            this.objTipoRecordEvaluacion = objTipoRecordEvaluacion;
            this.objRecordAcademico = objRecordAcademico;
            this.nota = nota;
        }
        private int idRecordEvaluacion;

        public int IdRecordEvaluacion
        {
            get { return idRecordEvaluacion; }
            set { idRecordEvaluacion = value; }
        }
        private TipoRecordEvaluacion objTipoRecordEvaluacion;

        public TipoRecordEvaluacion ObjTipoRecordEvaluacion
        {
            get { return objTipoRecordEvaluacion; }
            set { objTipoRecordEvaluacion = value; }
        }
        private RecordEvaluacion objRecordAcademico;

        public RecordEvaluacion ObjRecordAcademico
        {
            get { return objRecordAcademico; }
            set { objRecordAcademico = value; }
        }
        private short nota;

        public short Nota
        {
            get { return nota; }
            set { nota = value; }
        }
    }
}
