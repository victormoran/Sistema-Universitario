using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Configuracion
    {
        public Configuracion() { }
        public Configuracion(int idConfiguracion,byte pesoPracticas,byte pesoParcial,byte pesoFinal,byte pesoSustitutorio)
        {
            this.idConfiguracion = idConfiguracion;
            this.pesoPracticas = pesoPracticas;
            this.pesoParcial = pesoParcial;
            this.pesoFinal = pesoFinal;
            this.pesoSustitutorio = pesoSustitutorio;
        }
        private int idConfiguracion;

        public int IdConfiguracion
        {
            get { return idConfiguracion; }
            set { idConfiguracion = value; }
        }
        private byte pesoPracticas;

        public byte PesoPracticas
        {
            get { return pesoPracticas; }
            set { pesoPracticas = value; }
        }
        private byte pesoParcial;

        public byte PesoParcial
        {
            get { return pesoParcial; }
            set { pesoParcial = value; }
        }
        private byte pesoFinal;

        public byte PesoFinal
        {
            get { return pesoFinal; }
            set { pesoFinal = value; }
        }
        private byte pesoSustitutorio;

        public byte PesoSustitutorio
        {
            get { return pesoSustitutorio; }
            set { pesoSustitutorio = value; }
        }
    }
}
