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
        ClLibroL libroL = new ClLibroL();

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
            pnlListarLibros.Visible = false;
        }


        protected void btnListar_Click(object sender, EventArgs e)
        {
            pnlListarLibros.Visible = true;
            gvLibros.DataSource = libroL.ObtenerLibros();
            gvLibros.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlAgregar.Visible = true;
        }
        void ListarLibros()
        {
            gvLibros.DataSource = libroL.ObtenerLibros();
            gvLibros.DataBind();
        }

        protected void btnAgeragrN_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTitulo.Text) ||
                string.IsNullOrEmpty(txtAutor.Text) ||
                string.IsNullOrEmpty(txtNserie.Text) ||
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
            ClLibro libros = new ClLibro()
            {
                titulo = txtTitulo.Text,
                autor = txtAutor.Text,
                numeroDeSerie = numeroSerie,
                cantidadDePaginas = numeroPaginas,
                idCategoria = int.Parse(ddlCategoria.SelectedValue)
            };

            bool resultado;
            if (ViewState[""] != null)
            {

            }

            if (ViewState["idLibro"] != null)
            {
                libros.idLibro = (int)ViewState["idLibro"];
                resultado = libroL.validar_edit(libros);
                ViewState["idLibro"] = null;
                btnAgeragrN.Text = "Guardar cambios";
            }
            else
            {
                resultado = libroL.validar_libroN(libros);
            }
            
            if (resultado)
            {
                lblMensaNumer.Text = "Libro agregado correctamente";
                ListarLibros();
            }
            else
            {
                lblMensaNumer.Text = "Error al agregar el libro";
            }                     
        }

        void CargarLibro(int idLibro)
        {
            
            ClLibro libro = libroL.ObtenerLibroPorId(idLibro);

            if (libro != null)
            {
                txtTitulo.Text = libro.titulo;
                txtAutor.Text = libro.autor;
                txtNserie.Text = libro.numeroDeSerie.ToString();
                txtNpaginas.Text = libro.cantidadDePaginas.ToString();
                ddlCategoria.SelectedValue = libro.idCategoria.ToString();

                ViewState["idLibro"] = idLibro;
                pnlAgregar.Visible = true;  
            }
        }

        void EliminarLibro(ClLibro idLibro)
        {
            ClLibroL libroL= new ClLibroL();
            libroL.EliminarLibro(idLibro);
            ListarLibros();
        }

        

        protected void gvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idLibro = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                CargarLibro(idLibro);
            }
            else if (e.CommandName == "Eliminar")
            {
                //agregar void para eliminar
            }
        }
    }
}