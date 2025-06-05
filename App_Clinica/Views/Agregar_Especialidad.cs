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
        private DataTable dtEspecialidad;        // Contendrá los registros de la tabla SQL
        private bool enEdicion = false;          // Indica si estamos editando una fila existente
        private string idEnEdicion = null;
        public Agregar_Especialidad()
        {
            InitializeComponent();
            placeholderManager = new PlaceholderManager(placeholderColor, textColor);
            ConfigurarPlaceholders();
            InicializarDataTable();
            CargarEspecialidadesDesdeBD();
        }

        private void Agregar_Especialidad_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView
            dgvEspecialidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidad.MultiSelect = false;
            dgvEspecialidad.AllowUserToAddRows = false;
            dgvEspecialidad.ReadOnly = true;
            dgvEspecialidad.AutoGenerateColumns = true;

            // Renombramos encabezados para mejor presentación (opcional)
            if (dgvEspecialidad.Columns["Id"] != null)
                dgvEspecialidad.Columns["Id"].HeaderText = "ID";
            if (dgvEspecialidad.Columns["Nombre"] != null)
                dgvEspecialidad.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvEspecialidad.Columns["Descripcion"] != null)
                dgvEspecialidad.Columns["Descripcion"].HeaderText = "Descripción";
            if (dgvEspecialidad.Columns["Estado"] != null)
                dgvEspecialidad.Columns["Estado"].HeaderText = "Estado (1=Activo, 0=Inactivo)";
        }
        private void InicializarDataTable()
        {
            dtEspecialidad = new DataTable();
            // Columnas tal como las traemos del SELECT: 
            //    ID_Especialidad AS Id, Nombre, Descripcion, Estado
            dtEspecialidad.Columns.Add(new DataColumn("Id", typeof(string)));
            dtEspecialidad.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dtEspecialidad.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dtEspecialidad.Columns.Add(new DataColumn("Estado", typeof(string)));
        }
        private void CargarEspecialidadesDesdeBD()
        {
            // Vaciar el DataTable antes de recargar
            dtEspecialidad.Clear();

            // Creamos la conexión usando tu clase Conexion
            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                string sql = @"
                    SELECT 
                        ID_Especialidad AS Id, 
                        Nombre, 
                        Descripcion, 
                        Estado 
                    FROM Especialidad;
                ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    try
                    {
                        da.Fill(dtEspecialidad);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar especialidades desde la base de datos:\n"
                                        + ex.Message,
                                        "Error BD",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Asignamos el DataTable al DataGridView
            dgvEspecialidad.DataSource = dtEspecialidad;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1) Generar nuevo ID (usa tu servicio)
            string idEspecialidad = "";
            try
            {
                AutenticacionService service = new AutenticacionService();
                idEspecialidad = service.GenerarIdEspecialidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ID de especialidad: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Insertar en BD
            try
            {
                using (SqlConnection conn = new Conexion().AbrirConexion())
                {
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        AutenticacionService.InsertarEspecialidad(
                            conn,
                            transaction,
                            idEspecialidad,
                            txtNombreEspecialidad.Text.Trim(),
                            txtDescripcionEspecialidad.Text.Trim()
                        );

                        transaction.Commit();

                        MessageBox.Show("Especialidad guardada correctamente.",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 3) Limpiar campos y recargar el DataGridView
                        txtNombreEspecialidad.Clear();
                        txtDescripcionEspecialidad.Clear();
                        enEdicion = false;
                        idEnEdicion = null;

                        CargarEspecialidadesDesdeBD();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al guardar la especialidad: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNombreEspecialidad.Clear();
            txtDescripcionEspecialidad.Clear();

            enEdicion = false;
            idEnEdicion = null;

            txtNombreEspecialidad.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow filaSeleccionada = dgvEspecialidad.SelectedRows[0];
            object valorId = filaSeleccionada.Cells["Id"].Value;

            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("La fila seleccionada no tiene un ID válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardamos el ID de la fila para luego, al guardar, saber que estamos en edición
            idEnEdicion = valorId.ToString();
            txtNombreEspecialidad.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtDescripcionEspecialidad.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();

            enEdicion = true;
            txtNombreEspecialidad.Focus();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para cambiar el estado.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow filaSeleccionada = dgvEspecialidad.SelectedRows[0];
            object valorId = filaSeleccionada.Cells["Id"].Value;

            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("La fila seleccionada no tiene un ID válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = valorId.ToString();
            // Buscamos dentro del DataTable la fila cuyo Id coincida
            DataRow[] filas = dtEspecialidad.Select($"Id = '{id}'");
            if (filas.Length > 0)
            {
                DataRow fila = filas[0];
                string estadoActual = fila["Estado"].ToString();
                // Invertir '1' → '0' ; '0' → '1'
                fila["Estado"] = (estadoActual == "1") ? "0" : "1";

                // (Opcional) Si quieres reflejar el cambio directo en la BD:
                // ActualizarEstadoEnBD(id, fila["Estado"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontró la fila para cambiar el estado.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
