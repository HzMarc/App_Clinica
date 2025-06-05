using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        public static void InsertarPaciente(SqlConnection conn, SqlTransaction transaction, string id, string nombres, string apellidos,
                                        string genero, string correo, string telefono, DateTime fechaNacimiento,
                                        string alergias, string enfermedades, string tipoSangre)
        {
            string query = @"INSERT INTO Paciente 
                        (ID_Paciente, Nombres, Apellidos, Genero, Correo, Telefono, Fecha_Nacimiento, Alergias, Enfermedades, Tipo_Sangre, Estado)
                         VALUES (@ID, @Nom, @Ape, @Gen, @Cor, @Tel, @Fecha, @Ale, @Enf, @TipoS, '1')";

            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Nom", nombres);
            cmd.Parameters.AddWithValue("@Ape", apellidos);
            cmd.Parameters.AddWithValue("@Gen", genero);
            cmd.Parameters.AddWithValue("@Cor", correo);
            cmd.Parameters.AddWithValue("@Tel", telefono);
            cmd.Parameters.AddWithValue("@Fecha", fechaNacimiento);
            cmd.Parameters.AddWithValue("@Ale", alergias);
            cmd.Parameters.AddWithValue("@Enf", enfermedades);
            cmd.Parameters.AddWithValue("@TipoS", tipoSangre);

            cmd.ExecuteNonQuery();
        }

        public static void InsertarUsuario(SqlConnection conn, SqlTransaction transaction, string idUsuario, string nombreUsuario, string contrasena, string rol)
        {
            string query = @"INSERT INTO Usuario 
                         (ID_Usuario, Nombre_Usuario, Contrasena_Usuario, Rol_Usuario, Estado)
                         VALUES (@ID, @User, @Pass, @Rol, '1')";

            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@ID", idUsuario);
            cmd.Parameters.AddWithValue("@User", nombreUsuario);
            cmd.Parameters.AddWithValue("@Pass", contrasena);
            cmd.Parameters.AddWithValue("@Rol", rol);

            cmd.ExecuteNonQuery();
        }

        public static void EnviarCorreo(string correoDestino, string usuario, string contrasena)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("henriquezquinterosmarcosjusue@gmail.com");
                mensaje.To.Add(correoDestino);
                mensaje.Subject = "Credenciales de Acceso a la App de Clinica MedCare"; // Asunto más específico

                mensaje.IsBodyHtml = true;

                string htmlBody = $@"
        <!DOCTYPE html>
        <html>
        <head>
            <style>
                body {{
                    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                    margin: 0;
                    padding: 0;
                    background-color: #f4f4f4;
                    color: #333333;
                }}
                .email-container {{
                    max-width: 600px;
                    margin: 20px auto;
                    background-color: #ffffff;
                    border-radius: 8px;
                    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
                    overflow: hidden;
                }}
                .header {{
                    background-color: #0078D4; /* Color azul de Microsoft, puedes cambiarlo al color de MedCare si lo tienes */
                    padding: 20px 30px;
                    color: #ffffff;
                    font-size: 24px;
                    font-weight: bold;
                    text-align: center;
                }}
                .header img {{
                    height: 30px; /* Ajusta según el tamaño de tu logo */
                    vertical-align: middle;
                    margin-right: 10px;
                }}
                .content {{
                    padding: 30px;
                    line-height: 1.6;
                }}
                .credentials {{
                    background-color: #e9e9e9;
                    padding: 15px;
                    border-radius: 4px;
                    margin-top: 20px;
                    margin-bottom: 20px;
                    text-align: center; /* Centrar las credenciales */
                }}
                .credentials p {{
                    margin: 5px 0;
                }}
                .credentials strong {{
                    color: #005a9e;
                }}
                .footer {{
                    background-color: #f0f0f0;
                    padding: 20px 30px;
                    font-size: 12px;
                    color: #777777;
                    text-align: center;
                    border-top: 1px solid #dddddd;
                }}
            </style>
        </head>
        <body>
            <div class='email-container'>
                <div class='header'>
                   
                    <span>Clínica MedCare</span>
                </div>
                <div class='content'>
                    <h2>¡Bienvenido a la App de Clínica MedCare!</h2>
                    <p>Hola,</p>
                    <p>Tus credenciales de acceso para la aplicación de Clínica MedCare han sido generadas:</p>
                    <div class='credentials'>
                        <p><strong>Usuario:</strong> {usuario}</p>
                        <p><strong>Contraseña:</strong> {contrasena}</p>
                    </div>
                    <p>Ya puedes iniciar sesión en la aplicación de Clínica MedCare con estos datos.</p>
                    <p>Si tienes alguna pregunta o necesitas ayuda, no dudes en contactar a nuestro soporte técnico.</p>
                    <p>Gracias,</p>
                    <p>El equipo de Clínica MedCare</p>
                </div>
                <div class='footer'>
                    <p>&copy; {DateTime.Now.Year} Clínica MedCare. Todos los derechos reservados.</p>
                    <p>[Dirección de Clínica MedCare o Enlace a Contacto]</p>
                </div>
            </div>
        </body>
        </html>";

                mensaje.Body = htmlBody;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("henriquezquinterosmarcosjusue@gmail.com", "ngaz unww geja fcdq");
                smtp.EnableSsl = true;

                smtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }
        public static string GenerarContrasena(int longitud = 10)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*";
            StringBuilder contrasena = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = random.Next(caracteres.Length);
                contrasena.Append(caracteres[index]);
            }

            return contrasena.ToString();
        }

        public string GenerarNuevoID()
        {
            string nuevoID = "U001";
            try
            {
                Conexion conexion = new Conexion();
                SqlConnection conn = conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("GenerarNuevoIDUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nuevoID = reader["NuevoID"].ToString();
                }

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar nuevo ID: " + ex.Message);
            }
            return nuevoID;
        }
        public string GenerarIdPaciente()
        {
            string nuevoIdP = "P001"; 
            try
            {
                using (SqlConnection conn = new Conexion().AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("GenerarIdPaciente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                nuevoIdP = reader["nuevoIdP"].ToString();
                            }
                            else
                            {
                                
                                MessageBox.Show("El procedimiento almacenado no devolvió un ID de paciente.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ID de paciente: " + ex.Message);
               
            }
            return nuevoIdP;
        }
        public static string GenerarNombreUsuarioUnico(string nombres, string apellidos, SqlConnection conn, SqlTransaction transaction = null)
        {
            string baseNombreUsuario = (nombres.Split(' ')[0] + "." + apellidos.Split(' ')[0]).ToLower();
            string nombreUsuario = baseNombreUsuario;
            int contador = 1;

            string query = "SELECT COUNT(*) FROM Usuario WHERE Nombre_Usuario = @NombreUsuario";

            bool existe = true;

            while (existe)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        existe = false;
                    }
                    else
                    {
                        nombreUsuario = baseNombreUsuario + contador;
                        contador++;
                    }
                }
            }

            return nombreUsuario;
        }
        public string GenerarIdMedico()
        {
            string nuevoID = "M001";
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string query = "SELECT TOP 1 ID_Medico FROM Medico ORDER BY ID_Medico DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string ultimoID = resultado.ToString();
                    int numero = int.Parse(ultimoID.Substring(1)) + 1;
                    nuevoID = "M" + numero.ToString("D3");
                }
            }
            return nuevoID;
        }
        public static void InsertarMedico(SqlConnection conn, SqlTransaction transaction,
        string idMedico, string nombres, string apellidos, string correo,
        string telefono, string idEspecialidad, string idUsuario)
        {
            string sql = @"INSERT INTO Medico
                (ID_Medico, Nombres, Apellidos, Correo, Telefono, ID_Especialidad, ID_Usuario, Estado)
                VALUES (@ID_Medico, @Nombres, @Apellidos, @Correo, @Telefono, @ID_Especialidad, @ID_Usuario, '1')";

            SqlCommand cmd = new SqlCommand(sql, conn, transaction);
            cmd.Parameters.AddWithValue("@ID_Medico", idMedico);
            cmd.Parameters.AddWithValue("@Nombres", nombres);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@ID_Especialidad", idEspecialidad);
            cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);

            cmd.ExecuteNonQuery();
        }
        public static bool ValidarCampos(Control control)
        {
            bool camposValidos = true;

            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.BackColor = Color.MistyRose;
                    camposValidos = false;
                }
                else if (c is ComboBox comboBox && comboBox.SelectedIndex == -1)
                {
                    comboBox.BackColor = Color.MistyRose;
                    camposValidos = false;
                }
                else
                {
                    c.BackColor = SystemColors.Window;
                }
            }

            return camposValidos;
        }
        public static DataTable ObtenerEspecialidades()
        {
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string sql = "SELECT ID_Especialidad, Nombre FROM Especialidad WHERE Estado = '1'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static void InsertarEspecialidad(SqlConnection conn, SqlTransaction transaction, string id, string nombre, string descripcion)
        {
            string sql = @"INSERT INTO Especialidad 
             (ID_Especialidad, Nombre, Descripcion, Estado)
             VALUES (@ID_Especialidad, @Nombre, @Descripcion, @Estado)";

            SqlCommand cmd = new SqlCommand(sql, conn, transaction);
            cmd.Parameters.AddWithValue("@ID_Especialidad", id);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd.Parameters.AddWithValue("@Estado", "1");
            cmd.ExecuteNonQuery();
        }
        public string GenerarIdEspecialidad()
        {
            string nuevoID = "E001";

            try
            {
                using (SqlConnection conn = new Conexion().AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("GenerarIdEspecialidad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nuevoID = reader["NuevoID"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ID de especialidad: " + ex.Message);
            }

            return nuevoID;
        }
    }
}
