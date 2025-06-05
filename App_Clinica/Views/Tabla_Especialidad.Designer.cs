namespace App_Clinica.Views
{
    partial class Tabla_Especialidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pnltool = new Panel();
            btnSalir = new Button();
            dgvEspecialidad = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            pnltool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgvEspecialidad);
            panel1.Controls.Add(pnltool);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 450);
            panel1.TabIndex = 12;
            // 
            // pnltool
            // 
            pnltool.BackColor = Color.FromArgb(227, 242, 253);
            pnltool.Controls.Add(btnSalir);
            pnltool.Dock = DockStyle.Top;
            pnltool.Location = new Point(0, 0);
            pnltool.Name = "pnltool";
            pnltool.Size = new Size(805, 29);
            pnltool.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Gray;
            btnSalir.Location = new Point(774, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(31, 29);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvEspecialidad
            // 
            dgvEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidad.Location = new Point(258, 77);
            dgvEspecialidad.Name = "dgvEspecialidad";
            dgvEspecialidad.Size = new Size(526, 298);
            dgvEspecialidad.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Tabla_Especialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(panel1);
            Name = "Tabla_Especialidad";
            Text = "Tabla_Especialidad";
            panel1.ResumeLayout(false);
            pnltool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DataGridView dgvEspecialidad;
        private Panel pnltool;
        private Button btnSalir;
    }
}