using BibliotecaApp.Datos;
using BibliotecaApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaApp.Logica
{
    public class ClLibroL
    {
        ClLibroD libroD = new ClLibroD();

        public bool validar_libroN(ClLibro libro)
        {
            //if (string.IsNullOrEmpty(libro.titulo))
            //    return false;

            return libroD.libro_Nuevo(libro);
        }
        
        public List<ClCategoria> ObtenerCategorias()
        {
            return libroD.traer_categorias();
        }

        public List<ClLibro> ObtenerLibros()
        {
            return libroD.listar_libros();
        }

        public bool validar_edit (ClLibro libro)
        {
            return libroD.Editar_Libro(libro);
        }

        public ClLibro ObtenerLibroPorId(int idLibro)
        {
            return libroD.ObtenerLibroPorId(idLibro);
        }
    }
}