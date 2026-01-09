using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaApp.Modelo
{
    public class ClLibros
    {
        public int idLibro { get; set; }
        public string titulo {  get; set; }
        public string autor {  get; set; }
        public int numeroDeSerie { get; set; }
        public int cantidadDePaginas { get; set; }
        public int idCategoria { get; set; }
    }
}