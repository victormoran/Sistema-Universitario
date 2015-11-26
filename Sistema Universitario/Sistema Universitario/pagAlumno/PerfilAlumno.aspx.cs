using Encapsulamiento;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Universitario.pagAlumno
{
    public partial class PerfilAlumno : System.Web.UI.Page
    {

        private AlumnosLogica alumnosLogica;
        private Alumno alumno;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                alumnosLogica = new AlumnosLogica();
                MostrarAlumno();
            }

        }

        public void MostrarAlumno()
        {
            string sexo;
            String estadoCivil;

            string cod = Session["usuario"].ToString();
            alumno = new Alumno();
            alumno = alumnosLogica.MostrarAlumno(cod);
            this.txtDni.Text = alumno.ObjPerfil.ObjPersona.Dni.ToString();
            this.txtNombre.Text = alumno.ObjPerfil.ObjPersona.Nombre.ToString();
            this.txtApellidos.Text = alumno.ObjPerfil.ObjPersona.Apellidos.ToString();
            this.txtEmail.Text = alumno.ObjPerfil.ObjPersona.Email.ToString();
            this.txtTelefono.Text = alumno.ObjPerfil.ObjPersona.Telefono.ToString();
            if (alumno.ObjPerfil.ObjPersona.Sexo == false)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "Masculino";
            }
            this.txtSexo.Text = sexo;
            this.txtDireccion.Text = alumno.ObjPerfil.ObjPersona.Direccion.ToString();
            if (alumno.ObjPerfil.ObjPersona.EstadoCivil == false)
            {
                estadoCivil = "Soltero(a)";
            }
            else
            {
                estadoCivil = "Casado(a)";
            }
            this.txtEstadocivil.Text = estadoCivil;
            this.txtFechaDeNacimineto.Text = alumno.ObjPerfil.ObjPersona.FechaNacimiento.ToShortDateString();
        }
        
    }
 }
