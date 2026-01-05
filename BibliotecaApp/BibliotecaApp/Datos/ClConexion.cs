using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class ClConexion
    {
        SqlConnection oConex = new SqlConnection("Data Source=DESKTOP-9VCLAG1\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True;");
        public SqlConnection MtAbriConexion()
        {
            oConex.Open();
            return oConex;
        }
        public SqlConnection MtCerrarConexion()
        {
            oConex.Close();
            return oConex;
        }
    }
}