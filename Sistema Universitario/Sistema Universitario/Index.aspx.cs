using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Sistema_Universitario
{
    public partial class Index : System.Web.UI.Page
    {
        UsuarioLogica UsuarioLogica;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            UsuarioLogica=new UsuarioLogica();
            String usuario = this.inputUsuario.Text;
            String password = this.inputPass.Text;
            int tipo=UsuarioLogica.verificarUsuario(usuario, password);
            if (tipo>0 && tipo<5)
            {
                Session["usuario"] = usuario;
                Session["tipo"] = tipo;
                switch (tipo)
                {
                    case 1:
                        Response.Redirect("~/pagAdministrador/Index.aspx");
                        break;
                    case 2:
                        Response.Redirect("~/pagCoordinador/Index.aspx");
                        break;
                    case 3:
                        Response.Redirect("~/pagDocente/Index.aspx");
                        break;
                    case 4:
                        Response.Redirect("~/pagAlumno/Index.aspx");
                        break;
                }
            }
            else
            {
                
            }
        }

    }
}