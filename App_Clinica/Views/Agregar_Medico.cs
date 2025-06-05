using App_Clinica.DataAccess;
using App_Clinica.Services;
using Microsoft.Data.SqlClient;
using System.Data;

namespace App_Clinica.Views
{
    public partial class Agregar_Medico : Form
    {
        private PlaceholderManager placeholderManager;
        private readonly Color placeholderColor = Color.FromArgb(160, 160, 160);
        private readonly Color textColor = Color.FromArgb(50, 50, 50);
        public Agregar_Medico()
        {
            InitializeComponent();
            placeholderManager = new PlaceholderManager(placeholderColor, textColor);
            ConfigurarPlaceholders();
            CargarEspecialidades();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void ConfigurarPlaceholders()
        {

            placeholderManager.AgregarPlaceholder(txtNombres, "Ingrese nombres");
            placeholderManager.AgregarPlaceholder(txtApellidos, "Ingrese apellidos");
            placeholderManager.AgregarPlaceholder(txtCorreo, "ejemplo@dominio.com");
            placeholderManager.AgregarPlaceholder(txtTelefono, "Número de teléfono (ej. 7XXXXXXX)");
            placeholderManager.AgregarPlaceholder(cmbEspecialidad, "Seleccione la especialidad");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!AutenticacionService.ValidarCampos(this))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AutenticacionService service = new AutenticacionService();
            string idMedico = service.GenerarIdMedico();
            string idUsuario = service.GenerarNuevoID();
            string contrasena = AutenticacionService.GenerarContrasena();
            string rol = "Médico";

            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string nombreUsuario = AutenticacionService.GenerarNombreUsuarioUnico(
                        txtNombres.Text,
                        txtApellidos.Text,
                        conn,
                        transaction
                    );

                    AutenticacionService.InsertarUsuario(conn, transaction, idUsuario, nombreUsuario, contrasena, rol);

                    AutenticacionService.InsertarMedico(
                        conn,
                        transaction,
                        idMedico,
                        txtNombres.Text,
                        txtApellidos.Text,
                        txtCorreo.Text,
                        txtTelefono.Text,
                        cmbEspecialidad.SelectedValue.ToString(),
                        idUsuario
                    );

                    AutenticacionService.EnviarCorreo(txtCorreo.Text, nombreUsuario, contrasena);

                    transaction.Commit();
                    MessageBox.Show("Médico registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar el médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private void CargarEspecialidades()
        {
            DataTable especialidades = AutenticacionService.ObtenerEspecialidades();

            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.DisplayMember = "Nombre";      
            cmbEspecialidad.ValueMember = "ID_Especialidad"; 
            cmbEspecialidad.SelectedIndex = -1; 
        }
    }
}
