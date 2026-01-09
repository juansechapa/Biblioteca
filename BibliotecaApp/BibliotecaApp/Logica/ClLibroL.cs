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

        public bool validar_liberoN(ClLibros libro)
        {
            //if (string.IsNullOrEmpty(libro.titulo))
            //    return false;

            return libroD.libro_Nuevo(libro);
        }
    }
}