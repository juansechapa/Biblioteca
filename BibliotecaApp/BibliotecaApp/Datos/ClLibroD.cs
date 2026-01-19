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
        //Metodo para agregar un libro nuevo
        public bool libro_Nuevo(ClLibro libro)
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

        //Listar todos los libros
        public List<ClLibro> listar_libros()
        {
            List<ClLibro> listaLibros = new List<ClLibro>();

            SqlCommand cli = new SqlCommand("SELECT \r\n    l.idLibro,\r\n    l.titulo,\r\n    l.autor,\r\n    l.numeroDeSerie,\r\n    l.cantidadDePaginas,\r\n    c.categoria\r\nFROM libros l\r\nINNER JOIN categoria c ON l.idCategoria = c.idCategoria\r\n", lb.MtAbriConexion());

            SqlDataReader lir = cli.ExecuteReader();

            while (lir.Read())
            {
                listaLibros.Add(new ClLibro
                {
                    idLibro = Convert.ToInt32(lir["idLibro"]),
                    titulo = Convert.ToString(lir["titulo"]),
                    autor = Convert.ToString(lir["autor"]),
                    numeroDeSerie = Convert.ToInt32(lir["numeroDeSerie"]),
                    cantidadDePaginas = Convert.ToInt32(lir["cantidadDePaginas"]),
                    categoria = lir["categoria"].ToString()
                });
            }
            lir.Close();
            lb.MtCerrarConexion();
            return listaLibros;
        }

        //Metodo para editar un libro
        public bool Editar_Libro(ClLibro libro)
        {
            SqlCommand add = new SqlCommand("update libros set titulo=@titulo, autor=@autor, numeroDeSerie=@numeroDeSerie, cantidadDePaginas=@cantidadDePaginas, idCategoria=@idCategoria where idLibro=@idLibro", lb.MtAbriConexion());

            add.Parameters.AddWithValue("@titulo", libro.titulo);
            add.Parameters.AddWithValue("@autor", libro.autor);
            add.Parameters.AddWithValue("@numeroDeSerie", libro.numeroDeSerie);
            add.Parameters.AddWithValue("@cantidadDePaginas", libro.cantidadDePaginas);
            add.Parameters.AddWithValue("@idCategoria", libro.idCategoria);
            add.Parameters.AddWithValue("@idLibro", libro.idLibro);

            int edi = add.ExecuteNonQuery();
            lb.MtCerrarConexion();
            return edi > 0;
        }

        //Metodo para eliminar libro
        public bool Eliminar_Libro(int idLibro)
        {
            SqlCommand cmd = new SqlCommand("delete from libros where idLibro = @idLibro", lb.MtAbriConexion());

            cmd.Parameters.AddWithValue("@idLibro", idLibro);

            int borrar = cmd.ExecuteNonQuery();
            lb.MtCerrarConexion();
            return borrar > 0;

        }
        //Metotodo para obtener libros por id
        public ClLibro ObtenerLibroPorId(int idLibro)
        {
            ClLibro libro = null;

            SqlCommand obi = new SqlCommand("select idLibro, titulo, autor, numeroDeSerie, cantidadDePaginas, idCategoria from libros where idLibro =  @idLibro", lb.MtAbriConexion());

            obi.Parameters.AddWithValue("@idLibro", idLibro);

            SqlDataReader dr = obi.ExecuteReader();

            if (dr.Read())
            {
                libro = new ClLibro
                {
                    idLibro = Convert.ToInt32(dr["idLibro"]),
                    titulo = dr["titulo"].ToString(),
                    autor = dr["autor"].ToString(),
                    numeroDeSerie = Convert.ToInt32(dr["numeroDeSerie"]),
                    cantidadDePaginas = Convert.ToInt32(dr["cantidadDePaginas"]),
                    idCategoria = Convert.ToInt32(dr["idCategoria"]),
                };
            }
            dr.Close();
            lb.MtCerrarConexion();
            return libro;
            
        
        }

        
    }
}   