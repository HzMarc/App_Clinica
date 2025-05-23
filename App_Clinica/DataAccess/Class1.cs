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
            //MARCOS
            //cadenaConexion = "Server=DESKTOP-1LBQ6O2;Database=Clinica;User Id=sa;Password=V7#pRw9z2@LmXQf&;;TrustServerCertificate=True;";
            //ELBIN
            cadenaConexion = "Server=ELBIN;Database=Clinica;User Id=sa;Password=12345;;TrustServerCertificate=True;";
            //FREDERICK
            //cadenaConexion = "Server=MORDO;Database=Clinica;User Id=sa;Password=2846;;TrustServerCertificate=True;";

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
