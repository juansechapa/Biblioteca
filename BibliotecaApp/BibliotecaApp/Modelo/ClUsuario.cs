using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BibliotecaApp.Modelo
{
    public class ClUsuario
    {
        public int idUsuario {  get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public int idRol {  get; set; }
    }
}