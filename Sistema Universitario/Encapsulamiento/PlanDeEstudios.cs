using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class PlanDeEstudios
    {
        public PlanDeEstudios() { }
        public PlanDeEstudios(int idPlanDeEstudios, Escuela objEscuela, string nombre) 
        {
            this.idPlanDeEstudios = idPlanDeEstudios;
            this.objEscuela=objEscuela;
            this.nombre=nombre;
        }
        private int idPlanDeEstudios;

        public int IdPlanDeEstudios
        {
            get { return idPlanDeEstudios; }
            set { idPlanDeEstudios = value; }
        }
        private Escuela objEscuela;

        public Escuela ObjEscuela
        {
            get { return objEscuela; }
            set { objEscuela = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
