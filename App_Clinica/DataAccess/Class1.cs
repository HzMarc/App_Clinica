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
            cadenaConexion = "Server=DESKTOP-1LBQ6O2;Database=BDPrueba;User Id=sa;Password=V7#pRw9z2@LmXQf&;";
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
