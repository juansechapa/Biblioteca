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
        ClLibroL categoriaL = new ClLibroL();

        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                ocultar();
                if (Session["VistaLibros"] != null)
                {
                    string opci = Session["VistaLibros"].ToString();
                    if (opci == "Opciones")
                    {
                        pnlAgregar.Visible = true;
                    }
                }
                ddlCategoria.DataSource = categoriaL.ObtenerCategorias();
                ddlCategoria.DataTextField = "categoria";
                ddlCategoria.DataValueField = "idCategoria";
                ddlCategoria.DataBind();
            }
        }

        void ocultar()
        {
            pnlAgregar.Visible = false;
        }


        protected void btnListar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlAgregar.Visible = true;
        }

        protected void btnAgeragrN_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtTitulo.Text)||
                string.IsNullOrEmpty(txtAutor.Text)||
                string.IsNullOrEmpty(txtNserie.Text)||
                string.IsNullOrEmpty(txtNpaginas.Text))
            {
                pnlAgregar.Visible = true;
                return;
            }

            int numeroSerie;
            int numeroPaginas;
            if (!int.TryParse(txtNserie.Text, out numeroSerie))
            {
                lblMensaNumer.Text = "El número de serie debe ser numérico";
                return;
            }
            if (!int.TryParse(txtNpaginas.Text, out numeroPaginas))
            {
                lblMensaNumer.Text = "La cantidad de páginas debe ser numérica";
                return;
            }
                ClLibros libros = new ClLibros()
                {
                    titulo = txtTitulo.Text,
                    autor = txtAutor.Text,  
                    numeroDeSerie = numeroSerie,
                    cantidadDePaginas = numeroPaginas,
                    idCategoria = int.Parse(ddlCategoria.SelectedValue)
                };

            ClLibroL libroL = new ClLibroL();
            bool resultado = libroL.validar_liberoN(libros);

            if (resultado)
            {
                lblMensaNumer.Text = "Libro agregado correctamente";

            }
            else
            {
                lblMensaNumer.Text = "Error al agregar el libro";
            }                     
        }        
    }
}