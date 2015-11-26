using datos;
using Encapsulamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AlumnosLogica
    {
        AlumnoDatos alumnoDatos;
        Alumno alumno;

        public Alumno MostrarAlumno(String usuario)
        {
            alumnoDatos = new AlumnoDatos();
            alumno = new Alumno();
            alumno = alumnoDatos.Mostraralumno(usuario);
            return alumno;
        }
    }
}
