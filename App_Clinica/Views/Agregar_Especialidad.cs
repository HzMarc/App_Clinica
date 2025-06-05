using App_Clinica.DataAccess;
using App_Clinica.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Clinica.Views
{
    public partial class Agregar_Especialidad : Form
    {
        private PlaceholderManager placeholderManager;
        private readonly Color placeholderColor = Color.FromArgb(160, 160, 160);
        private readonly Color textColor = Color.FromArgb(50, 50, 50);
        public Agregar_Especialidad()
        {
            InitializeComponent();
            placeholderManager = new PlaceholderManager(placeholderColor, textColor);
            ConfigurarPlaceholders();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idEspecialidad = "";
            try
            {
                AutenticacionService service = new AutenticacionService();
                idEspecialidad = service.GenerarIdEspecialidad();

                using (SqlConnection conn = new Conexion().AbrirConexion())
                {
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        AutenticacionService.InsertarEspecialidad(
                            conn,
                            transaction,
                            idEspecialidad,
                            txtNombreEspecialidad.Text,
                            txtDescripcionEspecialidad.Text
                        );

                        transaction.Commit();
                        MessageBox.Show("Especialidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al guardar la especialidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ID de especialidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        private void ConfigurarPlaceholders()
        {

            placeholderManager.AgregarPlaceholder(txtNombreEspecialidad, "Ingrese el nombre");
            placeholderManager.AgregarPlaceholder(txtDescripcionEspecialidad, "Ingrese una descripcion");
           
        }
    }
}
