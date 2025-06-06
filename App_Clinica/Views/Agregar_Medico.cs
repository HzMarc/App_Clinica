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
            idMedico = new AutenticacionService().GenerarIdMedico();
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
            if (dgvMedico.Columns["Id"] != null)
                dgvMedico.Columns["Id"].HeaderText = "ID Médico";
            if (dgvMedico.Columns["Nombres"] != null)
                dgvMedico.Columns["Nombres"].HeaderText = "Nombres";
            if (dgvMedico.Columns["Apellidos"] != null)
                dgvMedico.Columns["Apellidos"].HeaderText = "Apellidos";
            if (dgvMedico.Columns["Correo"] != null)
                dgvMedico.Columns["Correo"].HeaderText = "Correo";
            if (dgvMedico.Columns["Telefono"] != null)
                dgvMedico.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvMedico.Columns["ID_Especialidad"] != null)
                dgvMedico.Columns["ID_Especialidad"].HeaderText = "ID Especialidad";
            if (dgvMedico.Columns["ID_Usuario"] != null)
                dgvMedico.Columns["ID_Usuario"].HeaderText = "ID Usuario";
            if (dgvMedico.Columns["Estado"] != null)
                dgvMedico.Columns["Estado"].HeaderText = "Estado (1=Activo, 0=Inactivo)";
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
                string sql = @"
                    SELECT
                        ID_Medico    AS Id,
                        Nombres,
                        Apellidos,
                        Correo,
                        Telefono,
                        ID_Especialidad,
                        ID_Usuario,
                        Estado
                    FROM Medico;
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    try
                    {
                        da.Fill(dtMedico);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar médicos desde la base de datos:\n" + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            idMedico = new AutenticacionService().GenerarIdMedico();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(this))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        AutenticacionService.InsertarUsuario(conn, transaction, idUsuario, nombreUsuario, contrasena, rol);
                        AutenticacionService.InsertarMedico(conn, transaction, idMedico, txtNombres.Text.Trim(), txtApellidos.Text.Trim(), txtCorreo.Text.Trim(), txtTelefono.Text.Trim(), cmbEspecialidad.SelectedValue.ToString(), idUsuario);
                        AutenticacionService.EnviarCorreo(txtCorreo.Text.Trim(), nombreUsuario, contrasena);
                        transaction.Commit();
                        MessageBox.Show("Médico registrado correctamente. Ahora agregue el horario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtCorreo.Clear();
                        txtTelefono.Clear();
                        cmbEspecialidad.SelectedIndex = -1;
                        idMedico = service.GenerarIdMedico();
                        CargarMedicosDesdeBD();
                        Agregar_Horario horarioForm = new Agregar_Horario(idMedico);
                        horarioForm.ShowDialog();
                    }
                    else
                    {
                        string sqlUpdate = @"
                            UPDATE Medico
                            SET
                                Nombres = @Nombres,
                                Apellidos = @Apellidos,
                                Correo = @Correo,
                                Telefono = @Telefono,
                                ID_Especialidad = @ID_Especialidad
                            WHERE ID_Medico = @IdMedico;
                        ";
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
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtCorreo.Clear();
                        txtTelefono.Clear();
                        cmbEspecialidad.SelectedIndex = -1;
                        enEdicion = false;
                        idEnEdicion = null;
                        idMedico = new AutenticacionService().GenerarIdMedico();
                        CargarMedicosDesdeBD();
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
            DataGridViewRow filaSeleccionada = dgvMedico.SelectedRows[0];
            object valorId = filaSeleccionada.Cells["Id"].Value;
            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("La fila seleccionada no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string id = valorId.ToString();
            string estadoActual = filaSeleccionada.Cells["Estado"].Value.ToString();
            string nuevoEstado = estadoActual == "1" ? "0" : "1";
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string sql = @"
                    UPDATE Medico
                    SET Estado = @Estado
                    WHERE ID_Medico = @IdMedico;
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@IdMedico", id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cambiar el estado en BD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DataGridViewRow filaSeleccionada = dgvMedico.SelectedRows[0];
            object valorId = filaSeleccionada.Cells["Id"].Value;
            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("La fila seleccionada no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            idEnEdicion = valorId.ToString();
            txtNombres.Text = filaSeleccionada.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = filaSeleccionada.Cells["Apellidos"].Value.ToString();
            txtCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
            txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
            cmbEspecialidad.SelectedValue = filaSeleccionada.Cells["ID_Especialidad"].Value.ToString();
            enEdicion = true;
            txtNombres.Focus();
        }
    }
}
