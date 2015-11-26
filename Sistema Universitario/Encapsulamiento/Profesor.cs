using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Profesor
    {
        public Profesor() { }
        public Profesor(int idProfesor,Perfil objPerfil) 
        {
            this.idProfesor = idProfesor;
            this.objPerfil = objPerfil;
        }
        private int idProfesor;

        public int IdProfesor
        {
            get { return idProfesor; }
            set { idProfesor = value; }
        }
        private Perfil objPerfil;

        public Perfil ObjPerfil
        {
            get { return objPerfil; }
            set { objPerfil = value; }
        }
    }

}
