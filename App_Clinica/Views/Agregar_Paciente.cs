using App_Clinica.DataAccess;
using App_Clinica.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace App_Clinica.Views
{
    public partial class Agregar_Paciente : Form
    {
        private PlaceholderManager placeholderManager;
        private readonly Color placeholderColor = Color.FromArgb(160, 160, 160);
        private readonly Color textColor = Color.FromArgb(50, 50, 50);
        private DataTable dtPaciente;
        private bool enEdicion = false;
        private string idEnEdicion = null;

        public Agregar_Paciente()
        {
            InitializeComponent();
            placeholderManager = new PlaceholderManager(placeholderColor, textColor);
            ConfigurarPlaceholders();
            InicializarDataTable();
            CargarPacientesDesdeBD();
        }

        private void Agregar_Paciente_Load(object sender, EventArgs e)
        {
            dgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaciente.MultiSelect = false;
            dgvPaciente.AllowUserToAddRows = false;
            dgvPaciente.ReadOnly = true;
            dgvPaciente.AutoGenerateColumns = true;
            if (dgvPaciente.Columns["Id"] != null)
                dgvPaciente.Columns["Id"].HeaderText = "ID Paciente";
            if (dgvPaciente.Columns["Nombres"] != null)
                dgvPaciente.Columns["Nombres"].HeaderText = "Nombres";
            if (dgvPaciente.Columns["Apellidos"] != null)
                dgvPaciente.Columns["Apellidos"].HeaderText = "Apellidos";
            if (dgvPaciente.Columns["Genero"] != null)
                dgvPaciente.Columns["Genero"].HeaderText = "Género";
            if (dgvPaciente.Columns["Correo"] != null)
                dgvPaciente.Columns["Correo"].HeaderText = "Correo";
            if (dgvPaciente.Columns["Telefono"] != null)
                dgvPaciente.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvPaciente.Columns["Fecha_Nacimiento"] != null)
                dgvPaciente.Columns["Fecha_Nacimiento"].HeaderText = "Fecha Nac.";
            if (dgvPaciente.Columns["Alergias"] != null)
                dgvPaciente.Columns["Alergias"].HeaderText = "Alergias";
            if (dgvPaciente.Columns["Enfermedades"] != null)
                dgvPaciente.Columns["Enfermedades"].HeaderText = "Enfermedades";
            if (dgvPaciente.Columns["Tipo_Sangre"] != null)
                dgvPaciente.Columns["Tipo_Sangre"].HeaderText = "Tipo Sangre";
            if (dgvPaciente.Columns["Estado"] != null)
                dgvPaciente.Columns["Estado"].HeaderText = "Estado (1=Activo, 0=Inactivo)";
        }

        private void InicializarDataTable()
        {
            dtPaciente = new DataTable();
            dtPaciente.Columns.Add(new DataColumn("Id", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Nombres", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Genero", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Correo", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Telefono", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Fecha_Nacimiento", typeof(DateTime)));
            dtPaciente.Columns.Add(new DataColumn("Alergias", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Enfermedades", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Tipo_Sangre", typeof(string)));
            dtPaciente.Columns.Add(new DataColumn("Estado", typeof(string)));
        }

        private void CargarPacientesDesdeBD()
        {
            dtPaciente.Clear();
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string sql = @"
                    SELECT
                        ID_Paciente AS Id,
                        Nombres,
                        Apellidos,
                        Genero,
                        Correo,
                        Telefono,
                        Fecha_Nacimiento,
                        Alergias,
                        Enfermedades,
                        Tipo_Sangre,
                        Estado
                    FROM Paciente;
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtPaciente);
                }
            }
            dgvPaciente.DataSource = dtPaciente;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtNombres.BackColor = Color.White;
            txtApellidos.Clear();
            txtApellidos.BackColor = Color.White;
            txtTelefono.Clear();
            txtTelefono.BackColor = Color.White;
            txtPeso.Clear();
            txtPeso.BackColor = Color.White;
            txtAltura.Clear();
            txtAltura.BackColor = Color.White;
            dtpNacimiento.Value = DateTime.Now;
            cmbGenero.SelectedIndex = -1;
            cmbGenero.BackColor = Color.White;
            txtCorreo.Clear();
            txtCorreo.BackColor = Color.White;
            cmbTipoSangre.SelectedIndex = -1;
            cmbTipoSangre.BackColor = Color.White;
            txtAlergias.Clear();
            txtAlergias.BackColor = Color.White;
            txtEnfermedades.Clear();
            txtEnfermedades.BackColor = Color.White;
            enEdicion = false;
            idEnEdicion = null;
            txtNombres.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(this))
            {
                MessageBox.Show("Por favor, corrige los campos marcados.", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    if (!enEdicion)
                    {
                        AutenticacionService autenticacionService = new AutenticacionService();
                        string idPaciente = autenticacionService.GenerarIdPaciente();
                        AutenticacionService.InsertarPaciente(
                            conn,
                            transaction,
                            idPaciente,
                            txtNombres.Text.Trim(),
                            txtApellidos.Text.Trim(),
                            cmbGenero.Text,
                            txtCorreo.Text.Trim(),
                            txtTelefono.Text.Trim(),
                            dtpNacimiento.Value.Date,
                            txtAlergias.Text.Trim(),
                            txtEnfermedades.Text.Trim(),
                            cmbTipoSangre.Text
                        );
                        transaction.Commit();
                        MessageBox.Show("Paciente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNuevo_Click(null, null);
                        CargarPacientesDesdeBD();
                    }
                    else
                    {
                        string sqlUpdate = @"
                            UPDATE Paciente
                            SET
                                Nombres = @Nombres,
                                Apellidos = @Apellidos,
                                Genero = @Genero,
                                Correo = @Correo,
                                Telefono = @Telefono,
                                Fecha_Nacimiento = @FechaNacimiento,
                                Alergias = @Alergias,
                                Enfermedades = @Enfermedades,
                                Tipo_Sangre = @TipoSangre
                            WHERE ID_Paciente = @IdPaciente;
                        ";
                        using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text.Trim());
                            cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                            cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text);
                            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@FechaNacimiento", dtpNacimiento.Value.Date);
                            cmd.Parameters.AddWithValue("@Alergias", txtAlergias.Text.Trim());
                            cmd.Parameters.AddWithValue("@Enfermedades", txtEnfermedades.Text.Trim());
                            cmd.Parameters.AddWithValue("@TipoSangre", cmbTipoSangre.Text);
                            cmd.Parameters.AddWithValue("@IdPaciente", idEnEdicion);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNuevo_Click(null, null);
                        enEdicion = false;
                        idEnEdicion = null;
                        CargarPacientesDesdeBD();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private bool ValidarCampos(Control parent)
        {
            bool todosLlenos = true;
            Control primerCampoVacio = null;
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txt)
                {
                    string nombre = txt.Name.ToLower();
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.BackColor = Color.MistyRose;
                        if (primerCampoVacio == null) primerCampoVacio = txt;
                        todosLlenos = false;
                        continue;
                    }
                    else
                    {
                        txt.BackColor = Color.White;
                    }
                    if (nombre.Contains("correo"))
                    {
                        if (!Regex.IsMatch(txt.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        {
                            txt.BackColor = Color.MistyRose;
                            MessageBox.Show("Correo no válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt.Focus();
                            return false;
                        }
                    }
                    if (nombre.Contains("telefono"))
                    {
                        if (!Regex.IsMatch(txt.Text, @"^\d{8,15}$"))
                        {
                            txt.BackColor = Color.MistyRose;
                            MessageBox.Show("Número de teléfono inválido. Solo se permiten números (8 a 15 dígitos).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt.Focus();
                            return false;
                        }
                    }
                    if (nombre.Contains("peso") || nombre.Contains("altura"))
                    {
                        if (!double.TryParse(txt.Text, out double valor) || valor <= 0)
                        {
                            txt.BackColor = Color.MistyRose;
                            MessageBox.Show($"Valor inválido en {(nombre.Contains("peso") ? "peso" : "altura")}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt.Focus();
                            return false;
                        }
                    }
                }
                else if (control is ComboBox cmb)
                {
                    if (cmb.SelectedIndex == -1)
                    {
                        cmb.BackColor = Color.MistyRose;
                        if (primerCampoVacio == null) primerCampoVacio = cmb;
                        todosLlenos = false;
                    }
                    else
                    {
                        cmb.BackColor = Color.White;
                    }
                }
                else if (control.HasChildren)
                {
                    if (!ValidarCampos(control))
                    {
                        todosLlenos = false;
                        if (primerCampoVacio == null) primerCampoVacio = control;
                    }
                }
            }
            primerCampoVacio?.Focus();
            return todosLlenos;
        }

        private void ConfigurarPlaceholders()
        {
            placeholderManager.AgregarPlaceholder(txtNombres, "Ingrese nombres");
            placeholderManager.AgregarPlaceholder(txtApellidos, "Ingrese apellidos");
            placeholderManager.AgregarPlaceholder(txtCorreo, "ejemplo@dominio.com");
            placeholderManager.AgregarPlaceholder(txtTelefono, "Número de teléfono (ej. 7XXXXXXX)");
            placeholderManager.AgregarPlaceholder(txtAlergias, "Describa alergias (si aplica)");
            placeholderManager.AgregarPlaceholder(txtEnfermedades, "Describa enfermedades crónicas (si aplica)");
            placeholderManager.AgregarPlaceholder(txtPeso, "Peso en kg");
            placeholderManager.AgregarPlaceholder(txtAltura, "Altura en cm");
            placeholderManager.AgregarPlaceholder(cmbGenero, "Seleccione género");
            placeholderManager.AgregarPlaceholder(cmbTipoSangre, "Seleccione tipo de sangre");
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para cambiar el estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow fila = dgvPaciente.SelectedRows[0];
            object valorId = fila.Cells["Id"].Value;
            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("La fila seleccionada no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string idPaciente = valorId.ToString();
            string estadoActual = fila.Cells["Estado"].Value.ToString();
            string nuevoEstado = estadoActual == "1" ? "0" : "1";
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string sql = @"
                    UPDATE Paciente
                    SET Estado = @Estado
                    WHERE ID_Paciente = @IdPaciente;
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                    cmd.ExecuteNonQuery();
                }
            }
            CargarPacientesDesdeBD();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow fila = dgvPaciente.SelectedRows[0];
            object valorId = fila.Cells["Id"].Value;
            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("La fila seleccionada no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            idEnEdicion = valorId.ToString();
            txtNombres.Text = fila.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
            cmbGenero.SelectedItem = fila.Cells["Genero"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            dtpNacimiento.Value = Convert.ToDateTime(fila.Cells["Fecha_Nacimiento"].Value);
            txtAlergias.Text = fila.Cells["Alergias"].Value.ToString();
            txtEnfermedades.Text = fila.Cells["Enfermedades"].Value.ToString();
            cmbTipoSangre.SelectedItem = fila.Cells["Tipo_Sangre"].Value.ToString();
            enEdicion = true;
            txtNombres.Focus();
        }
    }
}
