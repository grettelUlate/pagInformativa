using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using paginaInform.Models;

namespace paginaInform.Datos
{
    public class ConexionUsuario
    {
        //SqlConnection Connection = new SqlConnection();
        String connectionString;
        List<Models.empresaImagen> listaImagen = new List<Models.empresaImagen>();

        public void insertarUsuarios(Usuario empresa)
        {
            int id = 0;
            SqlCommand cmd = null;
            try
            {
                cmd = Conexion.GetConexion().CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"CALL insertarUsuario('" + empresa.Nombre + "', '" + empresa.Apellido + "', '" + empresa.correo + "','" + empresa.telefono + "','" + empresa.mensaje + "', '" + 1 + "')";

                cmd.Connection.Open();
                SqlDataReader DrListado = cmd.ExecuteReader();

                while (DrListado.Read())
                {
                    id = DrListado.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Dispose();
            }

        }

        public List<empresaImagen> listaimagen()
        {


            List<empresaImagen> lista = new List<empresaImagen>();

            SqlCommand cmd = null;
            cmd = Conexion.GetConexion().CreateCommand();
            //MySqlConnection con = Conexion.GetConexion();
            //cmd.Open();
            try
            {

                cmd = Conexion.GetConexion().CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"select * from imagenEmpresa";
                cmd.Connection.Open();
                SqlDataReader DrListado = cmd.ExecuteReader();
                empresaImagen tupla;
                while (DrListado.Read())
                {
                    tupla = new empresaImagen();
                    tupla.id_ImagenEmp = DrListado.GetInt32(0);
                    tupla.urlImagenEmp = DrListado.GetString(1);

                    lista.Add(tupla);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Dispose();
            }
            return lista;
        }

        public List<Models.empresaImagen> listaIm()        {
            List<empresaImagen> lista = new List<empresaImagen>();
            SqlCommand cmd = null;
            cmd = Conexion.GetConexion().CreateCommand();
          

            try            {
               
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from imagenEmpresa;";         
                SqlDataReader DrListado = cmd.ExecuteReader();
                empresaImagen tupla;
                while (DrListado.Read())    {
                    tupla = new empresaImagen();
                    tupla.id_ImagenEmp = DrListado.GetInt32(0);
                    tupla.urlImagenEmp = DrListado.GetString(1);
                    lista.Add(tupla);

                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Dispose();
            }
            return lista;
        }
    }
}