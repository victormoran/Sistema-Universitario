using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class RegistroGrupo
    {
        public RegistroGrupo() { }
        public RegistroGrupo(int idRegistroGrupo, Alumno objAlumno, Grupo objGrupo)
        {
            this.idRegistroGrupo = idRegistroGrupo;
            this.objAlumno = objAlumno;
            this.objGrupo = objGrupo;
        }
        private int idRegistroGrupo;

        public int IdRegistroGrupo
        {
            get { return idRegistroGrupo; }
            set { idRegistroGrupo = value; }
        }
        private Alumno objAlumno;

        public Alumno ObjAlumno
        {
            get { return objAlumno; }
            set { objAlumno = value; }
        }
        private Grupo objGrupo;

        public Grupo ObjGrupo
        {
            get { return objGrupo; }
            set { objGrupo = value; }
        }
    }
}
