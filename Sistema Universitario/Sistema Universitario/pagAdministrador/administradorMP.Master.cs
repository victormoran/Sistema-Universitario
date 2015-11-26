using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Universitario.pagAdministrador
{
    public partial class administradorMP : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.informacion__nombre__id.Text = (String)Session["usuario"];
            }
        }
    }
}