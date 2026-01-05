using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaApp.Vista
{
    public partial class principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlBuscar.Visible = false;
            pnlPerfil.Visible = false;
            if (Session["usuario"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblMensajee.Text = "Bienvenido";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlBuscar.Visible = true;
        }
        protected void btnVerLibros_Click(object sender, EventArgs e)
        {

        }
        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            pnlPerfil.Visible = true;
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        protected void btnBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}