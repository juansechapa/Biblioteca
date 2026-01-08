using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaApp.Vista
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                //lblMensajee.Text = "Bienvenido";
            }

            if (!IsPostBack)
            {
                OcultarPaneles();

                if (Session["VistaActiva"] != null) 
                {
                    string vista = Session["VistaActiva"].ToString();
                    if (vista == "Buscar")
                    {
                        pnlBuscar.Visible = true;
                    }
                    else if (vista == "Perfil")
                    {
                        pnlPerfil.Visible = true;
                    }
                        
                    
                }
            }
            
            
        }
        void OcultarPaneles()
        {
            pnlBuscar.Visible = false;
            pnlPerfil.Visible = false;
        }
        protected void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

    }
}