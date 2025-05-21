using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Clinica.DataAccess
{
    public class AutenticacionService
    {
        public static string IniciarSesion(string usuario, string contrasena)
        {
            string rol = null;
            try
            {
                Conexion conexion = new Conexion();
                SqlConnection conn = conexion.AbrirConexion();
                string query = @"SELECT Rol_Usuario 
                              FROM Usuario 
                              WHERE Nombre_Usuario = @Usuario 
                              AND Contrasena_Usuario = @Contrasena 
                              AND Estado = '1'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rol = reader["Rol_Usuario"].ToString();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
            return rol;
        }
    }
}
