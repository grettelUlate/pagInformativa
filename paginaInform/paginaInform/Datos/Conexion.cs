using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace paginaInform.Datos
{
    public class Conexion
    {
   
        public static SqlConnection GetConexion()
        {
           
            // SqlConnection Conn = new SqlConnection("server=(local);Initial Catalog=dbName;Integrated Security=True");
            SqlConnection conexion;
            conexion = new SqlConnection("Server=localhost ;DataBase=paginaInformativa;Integrated Security=SSPI");
            try {

                conexion.Open();
                Console.WriteLine("Conexion establecida");

            }
            catch (Exception e)
            {
                Console.WriteLine("Conexion fallida");
            }
            return conexion;
        }
    }
}