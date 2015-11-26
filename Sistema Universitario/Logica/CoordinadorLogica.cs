using datos;
using Encapsulamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CoordinadorLogica
    {
        CoordinadorDatos coordinadorDatos;
        Coordinador coordinador;

        public Coordinador MostrarCoordinador(String usuario)
        {
            coordinadorDatos = new CoordinadorDatos();
            coordinador = new Coordinador();
            coordinador = coordinadorDatos.MostrarCoordinador(usuario);
            return coordinador;
        }
    }
}
