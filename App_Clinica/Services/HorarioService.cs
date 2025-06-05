using App_Clinica.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clinica.Services
{
    public class HorarioService
    {
        public static bool VerificarHorariosPorMedico(string idMedico)
        {
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string query = "SELECT COUNT(*) FROM Horario WHERE ID_Medico = @ID_Medico AND Estado = '1'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Medico", idMedico);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public static void InsertarHorario(string idMedico, string dia, string horaInicio, string horaFin)
        {
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("InsertarHorario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Medico", idMedico);
                    cmd.Parameters.AddWithValue("@Dia", dia);
                    cmd.Parameters.AddWithValue("@Hora_Inicial", horaInicio);
                    cmd.Parameters.AddWithValue("@Hora_Final", horaFin);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static bool TieneHorarios(string idMedico)
        {
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string query = "SELECT COUNT(*) FROM Horario WHERE ID_Medico = @ID_Medico AND Estado = '1'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Medico", idMedico);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
