
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Clinica;
namespace App_Clinica.Views
{
    public partial class Menu : Form
    {
        private string nombreUsuarioActual = "";
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres salir del sistema?", "Cerrar Secion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se cerro la sesion", "Cerrar Secion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAggPac_Click(object sender, EventArgs e)
        {
            Agregar_Paciente agregar_Paciente = new Agregar_Paciente();
            agregar_Paciente.Show();
            this.Hide();
        }

        private void btnAggMed_Click(object sender, EventArgs e)
        {
            Agregar_Medico agregar_Medico = new Agregar_Medico();
            agregar_Medico.Show();
            this.Hide();
        }
        public void SetNombreUsuario(string nombreUsuario)
        {
            nombreUsuarioActual = nombreUsuario;
            timerMostrarSaludo.Start();
        }

        private void timerMostrarSaludo_Tick(object sender, EventArgs e)
        {
            timerMostrarSaludo.Stop();
            lblSaludo.Text = "Bienvenido, " + nombreUsuarioActual;
            lblSaludo.Visible = true;
            timerOcultarSaludo.Start();
        }

        private void timerOcultarSaludo_Tick(object sender, EventArgs e)
        {
            timerOcultarSaludo.Stop();
            lblSaludo.Visible = false;
            Task.Delay(500).ContinueWith(_ =>
            {
                Invoke((MethodInvoker)(() =>
                {
                    lblSaludo.Text = nombreUsuarioActual;
                    lblSaludo.Visible = true;

                }));

            });
        }
    }
}
