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

    public partial class Agregar_Horario : Form
    {

        private readonly string idMedicoAsignado;
        private string idMedico;
        public Agregar_Horario(string idMedico)
        {
            InitializeComponent();
            this.idMedicoAsignado = idMedico;
            this.idMedico = idMedico;
            CargarHorasLaborales();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Agregar_Medico agregarMedico = new Agregar_Medico();
            agregarMedico.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
            if (!chkLunes.Checked && !chkMartes.Checked && !chkMiercoles.Checked && !chkJueves.Checked &&
                !chkViernes.Checked && !chkSabado.Checked && !chkDomingo.Checked)
            {
                MessageBox.Show("Seleccione al menos un día para guardar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (chkLunes.Checked)
                    HorarioService.InsertarHorario(idMedico, "Lunes", cmbLunesDesde.Text, cmbLunesHasta.Text);

                if (chkMartes.Checked)
                    HorarioService.InsertarHorario(idMedico, "Martes", cmbMartesDesde.Text, cmbMartesHasta.Text);

                if (chkMiercoles.Checked)
                    HorarioService.InsertarHorario(idMedico, "Miércoles", cmbMiercolesDesde.Text, cmbMiercolesHasta.Text);

                if (chkJueves.Checked)
                    HorarioService.InsertarHorario(idMedico, "Jueves", cmbJuevesDesde.Text, cmbJuevesHasta.Text);

                if (chkViernes.Checked)
                    HorarioService.InsertarHorario(idMedico, "Viernes", cmbViernesDesde.Text, cmbViernesHasta.Text);

                if (chkSabado.Checked)
                    HorarioService.InsertarHorario(idMedico, "Sábado", cmbSabadoDesde.Text, cmbSabadoHasta.Text);

                if (chkDomingo.Checked)
                    HorarioService.InsertarHorario(idMedico, "Domingo", cmbDomingoDesde.Text, cmbDomingoHasta.Text);

                MessageBox.Show("Horario(s) guardado(s) exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar horarios: " + ex.Message);
            }
        }
        private void CargarHorasLaborales()
        {
            List<string> horas = new List<string>();
            DateTime hora = DateTime.Today.AddHours(7); // 07:00 AM
            DateTime fin = DateTime.Today.AddHours(19); // 07:00 PM

            while (hora <= fin)
            {
                horas.Add(hora.ToString("hh:mm tt")); // Formato: 07:00 AM
                hora = hora.AddMinutes(30);
            }

            // Agregar las horas a cada ComboBox
            cmbLunesDesde.Items.AddRange(horas.ToArray());
            cmbLunesHasta.Items.AddRange(horas.ToArray());
            cmbMartesDesde.Items.AddRange(horas.ToArray());
            cmbMartesHasta.Items.AddRange(horas.ToArray());
            cmbMiercolesDesde.Items.AddRange(horas.ToArray());
            cmbMiercolesHasta.Items.AddRange(horas.ToArray());
            cmbJuevesDesde.Items.AddRange(horas.ToArray());
            cmbJuevesHasta.Items.AddRange(horas.ToArray());
            cmbViernesDesde.Items.AddRange(horas.ToArray());
            cmbViernesHasta.Items.AddRange(horas.ToArray());
            cmbSabadoDesde.Items.AddRange(horas.ToArray());
            cmbSabadoHasta.Items.AddRange(horas.ToArray());
            cmbDomingoDesde.Items.AddRange(horas.ToArray());
            cmbDomingoHasta.Items.AddRange(horas.ToArray());
        }
    }
}