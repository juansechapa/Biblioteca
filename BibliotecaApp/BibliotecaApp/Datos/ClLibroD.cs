using BibliotecaApp.Logica;
using BibliotecaApp.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaApp.Datos
{
    public class ClLibroD
    {
        ClConexion lb = new ClConexion();
        public bool libro_Nuevo (ClLibros libro)
        {
            SqlCommand clb = new SqlCommand("insert into titulo, autor, numeroDeSerie, cantidadDePaginas, idCategoria"+
                "values (@titulo, @autor, @numeroDeSerie, @cantidadDePaginas, @idCategoria)", lb.MtAbriConexion());

            clb.Parameters.AddWithValue("@titulo", libro.titulo);
            clb.Parameters.AddWithValue("@autor", libro.autor);
            clb.Parameters.AddWithValue("@numeroDeSerie", libro.autor);
            clb.Parameters.AddWithValue("@cantidadDePaginas", libro.cantidadDePaginas);
            clb.Parameters.AddWithValue("@idCategoria", libro.idCategoria);

            int filasLb = clb.ExecuteNonQuery();
            lb.MtCerrarConexion();

            return filasLb > 0;
        }
    }
}