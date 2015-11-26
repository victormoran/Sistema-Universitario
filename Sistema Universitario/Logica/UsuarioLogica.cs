using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace Logica
{
    public class UsuarioLogica
    {
        UsuarioDatos usuarioDatos;

        public int verificarUsuario(string usuario, string password)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.VerificarUsuario(usuario, password);
        }
    }
}
