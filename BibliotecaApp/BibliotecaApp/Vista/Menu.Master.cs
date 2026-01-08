using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaApp.Vista
{ 
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Session["VistaActiva"] = "Buscar";
            Response.Redirect("Principal.aspx");
        }
        protected void btnVerLibros_Click(object sender, EventArgs e)
        {

        }
        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Session["VistaActiva"] = "Perfil";
            Response.Redirect("Principal.aspx");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
        
    }
}