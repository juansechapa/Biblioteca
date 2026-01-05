using BibliotecaApp.Logica;
using BibliotecaApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaApp.Vista
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegistro.Visible = false;

        }
        ClUsuarioL usuarioL = new ClUsuarioL();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;

            ClUsuario usuario = usuarioL.validarLogin(correo, contraseña);

            if (usuario != null)
            {
                Session["usuario"] = usuario;
                Response.Redirect("principal.aspx");
            }
            else
            {
                lblError.Text = "Correo o contraseña incorrectos";
                pnlLogin.Visible = true;
            }
        }


        protected void bntInicarSesion_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            pnlRegistro.Visible = true;
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text)||
            string.IsNullOrWhiteSpace(txtApellidos.Text)||
            string.IsNullOrWhiteSpace(txtCorreo_Registro.Text)||
            string.IsNullOrWhiteSpace(txtContraseña_Registro.Text))
            {
                lblMensaje.Text = "Todos los campos son obligatorios.";
                pnlRegistro.Visible = true;
                return;
            }
            ClUsuario usuario = new ClUsuario()
            {
                nombres = txtNombres.Text,
                apellidos = txtApellidos.Text,
                correo = txtCorreo_Registro.Text,
                contraseña = txtContraseña_Registro.Text
            };

            bool registrado = usuarioL.RegistrarUsuario(usuario);

            if (registrado)
            {
                lblMensaje.Text = "Usuario registrado correctamente";
                pnlRegistro.Visible = false;
                pnlLogin.Visible = true;
            }
            else
            {
                lblMensaje.Text = "Error al registrar";
                pnlRegistro.Visible = true;
                pnlLogin.Visible = false;
            }
        }
    }
}