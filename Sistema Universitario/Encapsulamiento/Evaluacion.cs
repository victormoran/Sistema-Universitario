using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Evaluacion
    {        
        public Evaluacion() { }
        public Evaluacion(int idEvaluacion, RegistroGrupo objRegistroGrupo, short practicas, short parcial, short final, short sustitutorio)
        {
            this.idEvaluacion = idEvaluacion;
            this.objRegistroGrupo = objRegistroGrupo;
            this.practicas = practicas;
            this.parcial = parcial;
            this.final = final;
            this.sustitutorio = sustitutorio;

        }
        private int idEvaluacion;

        public int IdEvaluacion
        {
            get { return idEvaluacion; }
            set { idEvaluacion = value; }
        }
        private RegistroGrupo objRegistroGrupo;

        public RegistroGrupo ObjRegistroGrupo
        {
            get { return objRegistroGrupo; }
            set { objRegistroGrupo = value; }
        }
        private short practicas;

        public short Practicas
        {
            get { return practicas; }
            set { practicas = value; }
        }
        private short parcial;

        public short Parcial
        {
            get { return parcial; }
            set { parcial = value; }
        }
        private short final;

        public short Final
        {
            get { return final; }
            set { final = value; }
        }
        private short sustitutorio;

        public short Sustitutorio
        {
            get { return sustitutorio; }
            set { sustitutorio = value; }
        }
    }
}
