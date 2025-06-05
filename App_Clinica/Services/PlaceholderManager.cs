using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clinica.Services
{
    public class PlaceholderManager
    {
        private Dictionary<Control, string> placeholders = new Dictionary<Control, string>();
        private Color placeholderColor = Color.FromArgb(160, 160, 160); 
        private Color textColor = Color.FromArgb(50, 50, 50); 

        public PlaceholderManager()
        {
           
        }

        public PlaceholderManager(Color placeholderColor, Color textColor)
        {
            this.placeholderColor = placeholderColor;
            this.textColor = textColor;
        }

        // Método para agregar un placeholder a un control
        public void AgregarPlaceholder(Control control, string placeholder)
        {
            if (!placeholders.ContainsKey(control))
            {
                placeholders.Add(control, placeholder);
                ConfigurarControl(control, placeholder);
            }
        }

        // Método para agregar múltiples placeholders de una vez
        public void AgregarPlaceholders(Dictionary<Control, string> nuevosPlaceholders)
        {
            foreach (var item in nuevosPlaceholders)
            {
                AgregarPlaceholder(item.Key, item.Value);
            }
        }

        // Configurar un control individual
        private void ConfigurarControl(Control control, string placeholder)
        {
            // Establecer el placeholder inicial
            control.Text = placeholder;
            control.ForeColor = placeholderColor;
            control.Tag = placeholder;

            // Asignar eventos según el tipo de control
            if (control is TextBox || control is ComboBox)
            {
                control.Enter += Control_Enter;
                control.Leave += Control_Leave;
            }
        }

        // Evento cuando el control recibe el foco
        private void Control_Enter(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl != null && ctrl.Text == ctrl.Tag?.ToString())
            {
                ctrl.Text = "";
                ctrl.ForeColor = textColor;
            }
        }

        // Evento cuando el control pierde el foco
        private void Control_Leave(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl != null && string.IsNullOrWhiteSpace(ctrl.Text))
            {
                ctrl.Text = ctrl.Tag?.ToString();
                ctrl.ForeColor = placeholderColor;
            }
        }

        // Método para verificar si un control tiene placeholder activo
        public bool TienePlaceholderActivo(Control control)
        {
            return control.Text == control.Tag?.ToString();
        }

        // Método para obtener el valor real de un control (sin placeholder)
        public string ObtenerValorReal(Control control)
        {
            if (TienePlaceholderActivo(control))
                return "";
            return control.Text;
        }

        // Método para limpiar todos los controles con placeholders
        public void LimpiarTodos()
        {
            foreach (var control in placeholders.Keys)
            {
                control.Text = placeholders[control];
                control.ForeColor = placeholderColor;
            }
        }

        // Método para validar que los campos requeridos no estén vacíos
        public bool ValidarCamposRequeridos(List<Control> camposRequeridos, out string mensaje)
        {
            mensaje = "";
            foreach (var control in camposRequeridos)
            {
                if (TienePlaceholderActivo(control) || string.IsNullOrWhiteSpace(ObtenerValorReal(control)))
                {
                    mensaje = $"El campo es requerido";
                    control.Focus();
                    return false;
                }
            }
            return true;
        }
    }
    public partial class FormPaciente : Form
    {
        // Instancia del PlaceholderManager
        private PlaceholderManager placeholderManager;

        // Colores del tema médico
        private readonly Color headerColor = Color.FromArgb(227, 242, 253);      // #E3F2FD
        private readonly Color textPrimary = Color.FromArgb(25, 118, 210);       // #1976D2
        private readonly Color backgroundForm = Color.FromArgb(255, 255, 255);   // #FFFFFF
        private readonly Color btnPrimary = Color.FromArgb(33, 150, 243);        // #2196F3
        private readonly Color btnSecondary = Color.FromArgb(100, 181, 246);     // #64B5F6
        private readonly Color btnTextWhite = Color.FromArgb(255, 255, 255);     // #FFFFFF
        private readonly Color placeholderColor = Color.FromArgb(160, 160, 160); // Gris placeholder
        private readonly Color textColor = Color.FromArgb(50, 50, 50);           // Texto normal

    }
}
