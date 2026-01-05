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
            if (Session["usuario"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblMensajee.Text = "Bievenido";
            }
        }
    }
}