using Encapsulamiento;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Universitario.pagAdministrador
{
    public partial class PerfilAdministrador : System.Web.UI.Page
    {
        private AdministradorLogica administradorLogica;
        private Administrador administrador;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                administradorLogica = new AdministradorLogica();
                MostrarAdministrador();
            }

        }

        public void MostrarAdministrador ()
        {
            string sexo;
            String estadoCivil;

            string cod=Session["usuario"].ToString();
            administrador = new Administrador();
            administrador = administradorLogica.MostrarAdministrador(cod);
            this.txtDni.Text = administrador.ObjPerfil.ObjPersona.Dni.ToString();
            this.txtNombre.Text = administrador.ObjPerfil.ObjPersona.Nombre.ToString();
            this.txtApellidos.Text = administrador.ObjPerfil.ObjPersona.Apellidos.ToString();
            this.txtEmail.Text = administrador.ObjPerfil.ObjPersona.Email.ToString();
            this.txtTelefono.Text = administrador.ObjPerfil.ObjPersona.Telefono.ToString();
            if (administrador.ObjPerfil.ObjPersona.Sexo == false)
            {
                sexo = "Femenino";
            }
            else 
            {
                sexo = "Masculino";
            }
            this.txtSexo.Text = sexo;
            this.txtDireccion.Text = administrador.ObjPerfil.ObjPersona.Direccion.ToString();
            if(administrador.ObjPerfil.ObjPersona.EstadoCivil==false)
            {
                estadoCivil="Soltero(a)";
            }
            else
            {
                estadoCivil="Casado(a)";
            }
            this.txtEstadocivil.Text = estadoCivil;
            this.txtFechaDeNacimineto.Text = administrador.ObjPerfil.ObjPersona.FechaNacimiento.ToShortDateString();
        }
    }
}