using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Administrador
    {       
        public Administrador(){}
        public Administrador(int idAdministrador, Perfil objPerfil)
        {
            this.idAdministrador = idAdministrador;
            this.objPerfil = objPerfil;
        }
        private int idAdministrador;

        public int IdAdministrador
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }
        private Perfil objPerfil;

        public Perfil ObjPerfil
        {
            get { return objPerfil; }
            set { objPerfil = value; }
        }


    }
}
