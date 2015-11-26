using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class CursoCadena
    {
       
        public CursoCadena() { }
        public CursoCadena(int idCursoCadena, CursoPlanDeEstudios objCursoPlanDeEstudios, String requisito) 
        {
            this.idCursoCadena = idCursoCadena;
            this.objCursoPlanDeEstudios = objCursoPlanDeEstudios;
            this.requisito = requisito;
        }
        private int idCursoCadena;

        public int IdCursoCadena
        {
            get { return idCursoCadena; }
            set { idCursoCadena = value; }
        }
        private CursoPlanDeEstudios objCursoPlanDeEstudios;

        public CursoPlanDeEstudios ObjCursoPlanDeEstudios
        {
            get { return objCursoPlanDeEstudios; }
            set { objCursoPlanDeEstudios = value; }
        }
        private String requisito;

        public String Requisito
        {
            get { return requisito; }
            set { requisito = value; }
        }
    }
}
