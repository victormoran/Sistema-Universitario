using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(int idUsuario, Perfil objPerfil, string usuario, string contraseña)
        {
            this.idUsuario = idUsuario;
            this.objPerfil = objPerfil;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private Perfil objPerfil;

        public Perfil ObjPerfil
        {
            get { return objPerfil; }
            set { objPerfil = value; }
        }
        private string usuario;

        public string Usuario1
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string contraseña;
        
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
    }
}
