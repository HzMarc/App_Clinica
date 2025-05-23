using App_Clinica.DataAccess;
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
using System.Text.RegularExpressions;



namespace App_Clinica.Views
{
    public partial class Agregar_Paciente : Form
    {
        public Agregar_Paciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(this))
            {
                MessageBox.Show("Por favor, corrige los campos marcados.", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AutenticacionService autenticacionService = new AutenticacionService();

            string idPaciente = autenticacionService.GenerarIdPaciente();
            string idUsuario = autenticacionService.GenerarNuevoID();
            string contrasena = AutenticacionService.GenerarContrasena();
            string rol = "Paciente";

            using (SqlConnection conn = new Conexion().AbrirConexion())
            {
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    AutenticacionService.InsertarPaciente(conn, transaction, idPaciente,
                        txtNombres.Text, txtApellidos.Text, cmbGenero.Text, txtCorreo.Text,
                        txtTelefono.Text, dtpNacimiento.Value.Date, txtAlergias.Text,
                        txtEnfermedades.Text, cmbTipoSangre.Text);

                    string nombreUsuario = AutenticacionService.GenerarNombreUsuarioUnico(
                        txtNombres.Text,
                        txtApellidos.Text,
                        conn,
                        transaction
                     );
                    AutenticacionService.EnviarCorreo(txtCorreo.Text, nombreUsuario, contrasena);
                    AutenticacionService.InsertarUsuario(conn, transaction, idUsuario, nombreUsuario, contrasena, rol);
                    transaction.Commit();
                    MessageBox.Show("Paciente y usuario creados correctamente.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
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

                    // Validación de teléfono
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


                    //if (nombre.Contains("edad"))
                    //{
                    //    if (!int.TryParse(txt.Text, out int edad) || edad < 0 || edad > 120)
                    //    {
                    //        txt.BackColor = Color.MistyRose;
                    //        MessageBox.Show("Edad no válida. Ingresa un número entre 0 y 120.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //        txt.Focus();
                    //        return false;
                    //    }
                    //}

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

        private void button1_Click(object sender, EventArgs e)
        {


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

            txtNombres.Focus();
        }
    }
}

