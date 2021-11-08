using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;

namespace ProyctoMVC
{
    public class conexion
    {
        NpgsqlConnection con = new NpgsqlConnection();
        String cadena = "server=localhost;port=5432;user id=postgres;password=123;database=mvc;";

        public NpgsqlConnection getConnexion()
        {
            try
            {
                con.ConnectionString = cadena;
                con.Open();
            }
            catch
            {

            }
            return con;
        }

        public void desconectar()
        {
            try
            {
                con.Close();
            }
            catch
            {

            }
        }
    }
}