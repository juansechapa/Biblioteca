using BibliotecaApp.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaApp.Datos
{
    public class ClUsuarioD
    {
        ClConexion cn = new ClConexion();

        public ClUsuario Login (string correo, string contraseña)
        {
            ClUsuario objUsuario = null;
            // TODO: Encriptar contraseña (pendiente por seguridad)

            SqlCommand cmd = new SqlCommand("SELECT idUsuario, nombres, apellidos, correo, idRol FROM usuario WHERE correo = @correo AND contraseña = @contraseña and idRol = 1", cn.MtAbriConexion());

            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                objUsuario = new ClUsuario()
                {
                    idUsuario = dr.GetInt32(0),
                    nombres = dr.GetString(1),
                    apellidos = dr.GetString(2),
                    correo = dr.GetString(3),
                    idRol = dr.GetInt32(4),
                    
                };
                
            }
            dr.Close();
            cn.MtCerrarConexion();
            return objUsuario;
        }
        //metodo para registrar usuario
        public bool Registrar(ClUsuario usuario)
        {
            SqlCommand cmd = new SqlCommand("insert into usuario (nombres, apellidos, correo, contraseña)" +
                "values(@nombres, @apellidos, @correo, @contraseña)", cn.MtAbriConexion());
            //agregar espacio para el telefono
            cmd.Parameters.AddWithValue("@nombres", usuario.nombres);
            cmd.Parameters.AddWithValue("@apellidos", usuario.apellidos);
            cmd.Parameters.AddWithValue("@correo", usuario.correo);
            cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);

            int filas = cmd.ExecuteNonQuery();
            cn.MtCerrarConexion();

            return filas > 0;
        }

        //Metodos del administradorAdministrador
        public ClUsuario LoginAdmin(string correo, string contraseña)
        {
            ClUsuario OjbAdmin = null;

            SqlCommand cmdAdmin = new SqlCommand("select idUsuario, nombres, apellidos, telefono, correo, idRol from usuario where correo = @correo AND contraseña = @contraseña and idRol = 2 ", cn.MtAbriConexion());

            cmdAdmin.Parameters.AddWithValue("@correo", correo);
            cmdAdmin.Parameters.AddWithValue("@contraseña", contraseña);

            SqlDataReader drA = cmdAdmin.ExecuteReader();

            if (drA.Read())
            {
                OjbAdmin = new ClUsuario()
                {
                    idUsuario = drA.GetInt32(0),
                    nombres = drA.GetString(1),
                    apellidos = drA.GetString(2),
                    telefono = drA.GetInt32(3),
                    correo = drA.GetString(4),
                    idRol = drA.GetInt32(5),
                };
            }
            drA.Close();
            cn.MtCerrarConexion();
            return OjbAdmin;
        }
    }
}