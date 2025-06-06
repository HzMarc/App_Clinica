using App_Clinica.DataAccess;
using App_Clinica.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace App_Clinica.Views
{
    public partial class Agregar_Medico : Form
    {
        private string idMedico = "";
        private PlaceholderManager placeholderManager;
        private readonly Color placeholderColor = Color.FromArgb(160, 160, 160);
        private readonly Color textColor = Color.FromArgb(50, 50, 50);
        private DataTable dtMedico;
        private bool enEdicion = false;
        private string idEnEdicion = null;

        public Agregar_Medico()
        {
            InitializeComponent();
            placeholderManager = new PlaceholderManager(placeholderColor, textColor);
            ConfigurarPlaceholders();
            CargarEspecialidades();
            InicializarDataTable();
            CargarMedicosDesdeBD();
        }

        private void Agregar_Medico_Load(object sender, EventArgs e)
        {
            dgvMedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedico.MultiSelect = false;
            dgvMedico.AllowUserToAddRows = false;
            dgvMedico.ReadOnly = true;
            dgvMedico.AutoGenerateColumns = true;

            if (dgvMedico.Columns["Id"] != null) dgvMedico.Columns["Id"].HeaderText = "ID Médico";
            if (dgvMedico.Columns["Nombres"] != null) dgvMedico.Columns["Nombres"].HeaderText = "Nombres";
            if (dgvMedico.Columns["Apellidos"] != null) dgvMedico.Columns["Apellidos"].HeaderText = "Apellidos";
            if (dgvMedico.Columns["Correo"] != null) dgvMedico.Columns["Correo"].HeaderText = "Correo";
            if (dgvMedico.Columns["Telefono"] != null) dgvMedico.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvMedico.Columns["ID_Especialidad"] != null) dgvMedico.Columns["ID_Especialidad"].HeaderText = "ID Especialidad";
            if (dgvMedico.Columns["ID_Usuario"] != null) dgvMedico.Columns["ID_Usuario"].HeaderText = "ID Usuario";
            if (dgvMedico.Columns["Estado"] != null) dgvMedico.Columns["Estado"].HeaderText = "Estado (1=Activo, 0=Inactivo)";
        }

        private void InicializarDataTable()
        {
            dtMedico = new DataTable();
            dtMedico.Columns.Add(new DataColumn("Id", typeof(string)));
            dtMedico.Columns.Add(new DataColumn("Nombres", typeof(string)));
            dtMedico.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            dtMedico.Columns.Add(new DataColumn("Correo", typeof(string)));
            dtMedico.Columns.Add(new DataColumn("Telefono", typeof(string)));
            dtMedico.Columns.Add(new DataColumn("ID_Especialidad", typeof(string)));
            dtMedico.Columns.Add(new DataColumn("ID_Usuario", typeof(string)));
            dtMedico.Columns.Add(new DataColumn("Estado", typeof(string)));
        }

        private void CargarMedicosDesdeBD()
        {
            dtMedico.Clear();
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string sql = @"SELECT ID_Medico AS Id, Nombres, Apellidos, Correo, Telefono, ID_Especialidad, ID_Usuario, Estado FROM Medico;";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    try { da.Fill(dtMedico); }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar médicos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            dgvMedico.DataSource = dtMedico;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            txtNombres.Focus();
            enEdicion = false;
            idEnEdicion = null;
            idMedico = ""; // lo generamos en guardar
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(this))
            {
                MessageBox.Show("Completa todos los campos antes de guardar.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    if (!enEdicion)
                    {
                        AutenticacionService service = new AutenticacionService();
                        string idUsuario = service.GenerarNuevoID();
                        string contrasena = AutenticacionService.GenerarContrasena();
                        string rol = "Médico";
                        string nombreUsuario = AutenticacionService.GenerarNombreUsuarioUnico(txtNombres.Text.Trim(), txtApellidos.Text.Trim(), conn, transaction);
                        idMedico = service.GenerarIdMedico();

                        // Insertar usuario y médico
                        AutenticacionService.InsertarUsuario(conn, transaction, idUsuario, nombreUsuario, contrasena, rol);
                        AutenticacionService.InsertarMedico(conn, transaction, idMedico, txtNombres.Text.Trim(), txtApellidos.Text.Trim(), txtCorreo.Text.Trim(), txtTelefono.Text.Trim(), cmbEspecialidad.SelectedValue.ToString(), idUsuario);

                        // Confirmar transacción
                        transaction.Commit();

                        // Enviar correo
                        AutenticacionService.EnviarCorreo(txtCorreo.Text.Trim(), nombreUsuario, contrasena);

                        MessageBox.Show("Médico registrado correctamente. Ahora agregue el horario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar campos
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtCorreo.Clear();
                        txtTelefono.Clear();
                        cmbEspecialidad.SelectedIndex = -1;
                        CargarMedicosDesdeBD();

                        // Abrir formulario de horarios
                        Agregar_Horario horarioForm = new Agregar_Horario(idMedico);
                        horarioForm.ShowDialog();
                    }
                    else
                    {
                        string sqlUpdate = @"
                            UPDATE Medico
                            SET Nombres = @Nombres, Apellidos = @Apellidos,
                                Correo = @Correo, Telefono = @Telefono,
                                ID_Especialidad = @ID_Especialidad
                            WHERE ID_Medico = @IdMedico;";
                        using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text.Trim());
                            cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@ID_Especialidad", cmbEspecialidad.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@IdMedico", idEnEdicion);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        MessageBox.Show("Médico actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMedicosDesdeBD();

                        // Reset
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtCorreo.Clear();
                        txtTelefono.Clear();
                        cmbEspecialidad.SelectedIndex = -1;
                        enEdicion = false;
                        idEnEdicion = null;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar el médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
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

        private void ConfigurarPlaceholders()
        {
            placeholderManager.AgregarPlaceholder(txtNombres, "Ingrese nombres");
            placeholderManager.AgregarPlaceholder(txtApellidos, "Ingrese apellidos");
            placeholderManager.AgregarPlaceholder(txtCorreo, "ejemplo@dominio.com");
            placeholderManager.AgregarPlaceholder(txtTelefono, "Número de teléfono (ej. 7XXXXXXX)");
            placeholderManager.AgregarPlaceholder(cmbEspecialidad, "Seleccione la especialidad");
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (dgvMedico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para cambiar el estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvMedico.SelectedRows[0].Cells["Id"].Value.ToString();
            string estadoActual = dgvMedico.SelectedRows[0].Cells["Estado"].Value.ToString();
            string nuevoEstado = estadoActual == "1" ? "0" : "1";

            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string sql = @"UPDATE Medico SET Estado = @Estado WHERE ID_Medico = @IdMedico;";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@IdMedico", id);
                    try { cmd.ExecuteNonQuery(); }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cambiar estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            CargarMedicosDesdeBD();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMedico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvMedico.SelectedRows[0];
            idEnEdicion = fila.Cells["Id"].Value.ToString();
            txtNombres.Text = fila.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            cmbEspecialidad.SelectedValue = fila.Cells["ID_Especialidad"].Value.ToString();
            enEdicion = true;
            txtNombres.Focus();
        }
    }
}
