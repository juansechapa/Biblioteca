using BibliotecaApp.Datos;
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
    public partial class Menu_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlAgregar.Visible = false;
        }

        

        protected void btnListar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAgeragrN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTitulo.Text)||
                string.IsNullOrEmpty(txtAutor.Text)||
                string.IsNullOrEmpty(txtNserie.Text)||
                string.IsNullOrEmpty(txtNpaginas.Text)||
                string.IsNullOrEmpty(txtCategoria.Text))
            {
                pnlAgregar.Visible = true;
                return;
            }

            int numeroSerie;
            int numeroPaginas;
            if (int.TryParse(txtNserie.Text, out numeroSerie))
            {
                lblMensaNumer.Text = "El número de serie debe ser numérico";
                return;
            }
            if (int.TryParse(txtNpaginas.Text, out numeroPaginas))
            {
                lblMensaNumer.Text = "La cantidad de páginas debe ser numérica";
            }
                ClLibros libros = new ClLibros()
                {
                    titulo = txtTitulo.Text,
                    autor = txtAutor.Text,  
                    numeroDeSerie = numeroSerie,
                    cantidadDePaginas = numeroPaginas,
                    //idCategoria = txtCategoria.Text,
                };
            if (!IsPostBack)
            {
                //ddlCategoria.DataSource = ClLibroL.
            }
        }
    }
}