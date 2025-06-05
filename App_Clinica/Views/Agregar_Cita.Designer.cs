namespace App_Clinica.Views
{
    partial class Agregar_Cita
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
            calendarFecha = new MonthCalendar();
            label4 = new Label();
            chkDomingo = new CheckBox();
            chkSabado = new CheckBox();
            chkViernes = new CheckBox();
            chkJueves = new CheckBox();
            chkMiercoles = new CheckBox();
            chkMartes = new CheckBox();
            chkLunes = new CheckBox();
            label2 = new Label();
            cmbMedico = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pnltool = new Panel();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnltool.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(calendarFecha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(chkDomingo);
            panel1.Controls.Add(chkSabado);
            panel1.Controls.Add(chkViernes);
            panel1.Controls.Add(chkJueves);
            panel1.Controls.Add(chkMiercoles);
            panel1.Controls.Add(chkMartes);
            panel1.Controls.Add(chkLunes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbMedico);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnltool);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 564);
            panel1.TabIndex = 0;
            // 
            // calendarFecha
            // 
            calendarFecha.CalendarDimensions = new Size(2, 1);
            calendarFecha.Location = new Point(42, 310);
            calendarFecha.MaxSelectionCount = 1;
            calendarFecha.Name = "calendarFecha";
            calendarFecha.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(25, 118, 210);
            label4.Location = new Point(42, 280);
            label4.Name = "label4";
            label4.Size = new Size(494, 21);
            label4.TabIndex = 88;
            label4.Text = "Seleccione la fecha de la cita en los dias disponibles del médico";
            // 
            // chkDomingo
            // 
            chkDomingo.AutoSize = true;
            chkDomingo.Location = new Point(430, 244);
            chkDomingo.Name = "chkDomingo";
            chkDomingo.Size = new Size(34, 19);
            chkDomingo.TabIndex = 87;
            chkDomingo.Text = "D";
            chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            chkSabado.AutoSize = true;
            chkSabado.Location = new Point(392, 244);
            chkSabado.Name = "chkSabado";
            chkSabado.Size = new Size(32, 19);
            chkSabado.TabIndex = 86;
            chkSabado.Text = "S";
            chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Location = new Point(353, 244);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(33, 19);
            chkViernes.TabIndex = 85;
            chkViernes.Text = "V";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Location = new Point(317, 244);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(30, 19);
            chkJueves.TabIndex = 84;
            chkJueves.Text = "J";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Location = new Point(271, 244);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(40, 19);
            chkMiercoles.TabIndex = 83;
            chkMiercoles.Text = "MI";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Location = new Point(228, 244);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(37, 19);
            chkMartes.TabIndex = 82;
            chkMartes.Text = "M";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Location = new Point(190, 244);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(32, 19);
            chkLunes.TabIndex = 81;
            chkLunes.Text = "L";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(25, 118, 210);
            label2.Location = new Point(42, 242);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 80;
            label2.Text = "Días disponibles:";
            // 
            // cmbMedico
            // 
            cmbMedico.BackColor = Color.WhiteSmoke;
            cmbMedico.FlatStyle = FlatStyle.Flat;
            cmbMedico.ForeColor = Color.DimGray;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(42, 198);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(189, 23);
            cmbMedico.TabIndex = 79;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 118, 210);
            label1.Location = new Point(42, 174);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 78;
            label1.Text = "Médico";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 242, 253);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 126);
            panel2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(227, 242, 253);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(25, 118, 210);
            label3.Location = new Point(306, 84);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 1;
            label3.Text = "Agregar Cita";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rescheduling_A_Task;
            pictureBox1.Location = new Point(321, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnltool
            // 
            pnltool.BackColor = Color.FromArgb(227, 242, 253);
            pnltool.Controls.Add(btnSalir);
            pnltool.Dock = DockStyle.Top;
            pnltool.Location = new Point(0, 0);
            pnltool.Name = "pnltool";
            pnltool.Size = new Size(706, 29);
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
            btnSalir.Location = new Point(675, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(31, 29);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Agregar_Cita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 564);
            Controls.Add(panel1);
            Name = "Agregar_Cita";
            Text = "Agregar_Cita";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnltool.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnltool;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private ComboBox cmbMedico;
        private CheckBox chkDomingo;
        private CheckBox chkSabado;
        private CheckBox chkViernes;
        private CheckBox chkJueves;
        private CheckBox chkMiercoles;
        private CheckBox chkMartes;
        private CheckBox chkLunes;
        private Label label2;
        private MonthCalendar calendarFecha;
        private Label label4;
    }
}