using Encapsulamiento;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Universitario.pagCoordinador
{
    public partial class PerfilCoordinador : System.Web.UI.Page
    {
        private CoordinadorLogica coordinadorLogica;
        private Coordinador coordinador;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                coordinadorLogica = new CoordinadorLogica();
                MostrarCoordinador();
            }
        }

        public void MostrarCoordinador()
        {
            string sexo;
            String estadoCivil;

            string cod = Session["usuario"].ToString();
            coordinador = new Coordinador();
            coordinador = coordinadorLogica.MostrarCoordinador(cod);
            this.txtDni.Text = coordinador.ObjPerfil.ObjPersona.Dni.ToString();
            this.txtNombre.Text = coordinador.ObjPerfil.ObjPersona.Nombre.ToString();
            this.txtApellidos.Text = coordinador.ObjPerfil.ObjPersona.Apellidos.ToString();
            this.txtEmail.Text = coordinador.ObjPerfil.ObjPersona.Email.ToString();
            this.txtTelefono.Text = coordinador.ObjPerfil.ObjPersona.Telefono.ToString();
            if (coordinador.ObjPerfil.ObjPersona.Sexo == false)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "Masculino";
            }
            this.txtSexo.Text = sexo;
            this.txtDireccion.Text = coordinador.ObjPerfil.ObjPersona.Direccion.ToString();
            if (coordinador.ObjPerfil.ObjPersona.EstadoCivil == false)
            {
                estadoCivil = "Soltero(a)";
            }
            else
            {
                estadoCivil = "Casado(a)";
            }
            this.txtEstadocivil.Text = estadoCivil;
            this.txtFechaDeNacimineto.Text = coordinador.ObjPerfil.ObjPersona.FechaNacimiento.ToShortDateString();
        }

    }
}