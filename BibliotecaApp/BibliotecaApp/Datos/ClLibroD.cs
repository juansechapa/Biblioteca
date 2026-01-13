using BibliotecaApp.Logica;
using BibliotecaApp.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaApp.Datos
{
    public class ClLibroD
    {
        ClConexion lb = new ClConexion();
        //metodo para traer agregar un libro nuevo
        public bool libro_Nuevo(ClLibros libro)
        {
            SqlCommand clb = new SqlCommand("insert into libros (titulo, autor, numeroDeSerie, cantidadDePaginas, idCategoria)" +
                "values (@titulo, @autor, @numeroDeSerie, @cantidadDePaginas, @idCategoria)", lb.MtAbriConexion());

            clb.Parameters.AddWithValue("@titulo", libro.titulo);
            clb.Parameters.AddWithValue("@autor", libro.autor);
            clb.Parameters.AddWithValue("@numeroDeSerie", libro.numeroDeSerie);
            clb.Parameters.AddWithValue("@cantidadDePaginas", libro.cantidadDePaginas);
            clb.Parameters.AddWithValue("@idCategoria", libro.idCategoria);

            int filasLb = clb.ExecuteNonQuery();
            lb.MtCerrarConexion();

            return filasLb > 0;
        }
        //Metodo para traer todas las categorias
        public List<ClCategoria> traer_categorias()
        {
            List<ClCategoria> lista = new List<ClCategoria>();

            SqlCommand cml = new SqlCommand("SELECT idCategoria, categoria FROM categoria", lb.MtAbriConexion());

            SqlDataReader drl = cml.ExecuteReader();

            while (drl.Read())
            {
                lista.Add(new ClCategoria
                {
                    idCategoria = drl.GetInt32(0),
                    categoria = drl.GetString(1),
                });
            }
            drl.Close();
            lb.MtCerrarConexion();
            return lista;
        }

        //Metodo para listar todos los libros
        public List <ClLibros> listar_libros()
        {
            List<ClLibros> listaLibros = new List<ClLibros>();

            SqlCommand cli = new SqlCommand("select * from libro",lb.MtAbriConexion());

            SqlDataReader lir = cli.ExecuteReader();

            while (lir.Read())
            {
                listaLibros.Add(new ClLibros
                {
                    idLibro = Convert.ToInt32(lir["idLibros"]),
                    titulo = Convert.ToString(lir["titulo"]),
                    autor = Convert.ToString(lir["autor"]),
                    numeroDeSerie = Convert.ToInt32(lir["numeroDeSerie"]),
                    cantidadDePaginas = Convert.ToInt32(lir["cantidadDePaginas"]),
                    idCategoria = Convert.ToInt32(lir["idCategoria"])
                });
            }
            lir.Close();
            lb.MtCerrarConexion();
            return listaLibros;
        }
    }
}   