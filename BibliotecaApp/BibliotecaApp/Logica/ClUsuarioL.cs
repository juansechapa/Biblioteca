using BibliotecaApp.Datos;
using BibliotecaApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaApp.Logica
{
    public class ClUsuarioL
    {
        ClUsuarioD usuarioD = new ClUsuarioD();

        public ClUsuario validarLogin (string correo, string contraseña)
        {
            return usuarioD.Login(correo, contraseña);
        }

        public bool RegistrarUsuario(ClUsuario usuario)
        {
            return usuarioD.Registrar(usuario);
        }

        //Metodos de administrador
        public ClUsuario validarLogin_Admin(string correo, string contraseña)
        {
            return usuarioD.LoginAdmin(correo, contraseña);
        }
    }
}