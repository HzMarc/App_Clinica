using System;
using Microsoft.Data.SqlClient;

namespace App_Clinica.DataAccess
{
    public class Conexion
    {
        private SqlConnection conexion;
        private string cadenaConexion;

        public Conexion()
        {  
           
            cadenaConexion = "Server=localhost;Database=Clinica;User Id=sa;Password=Salud123#;;TrustServerCertificate=True;";
           

            conexion = new SqlConnection(cadenaConexion);


        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }

}
