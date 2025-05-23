namespace App_Clinica.Views
{
    partial class Agregar_Paciente
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
            pictureBox1 = new PictureBox();
            dtpNacimiento = new DateTimePicker();
            txtCorreo = new TextBox();
            label12 = new Label();
            cmbGenero = new ComboBox();
            label11 = new Label();
            btnGuardar = new Button();
            btnNuevo = new Button();
            cmbTipoSangre = new ComboBox();
            txtEnfermedades = new TextBox();
            txtAlergias = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            label10 = new Label();
            panel2 = new Panel();
            btnSalir = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dtpNacimiento);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(cmbTipoSangre);
            panel1.Controls.Add(txtEnfermedades);
            panel1.Controls.Add(txtAlergias);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 705);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Paciente;
            pictureBox1.Location = new Point(415, 61);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 94);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(161, 523);
            dtpNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(282, 27);
            dtpNacimiento.TabIndex = 28;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(161, 636);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(282, 27);
            txtCorreo.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(65, 633);
            label12.Name = "label12";
            label12.Size = new Size(75, 28);
            label12.TabIndex = 26;
            label12.Text = "Correo";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino ", "Femenino" });
            cmbGenero.Location = new Point(161, 583);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(282, 28);
            cmbGenero.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(65, 585);
            label11.Name = "label11";
            label11.Size = new Size(80, 28);
            label11.TabIndex = 24;
            label11.Text = "Género";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gray;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources.Save;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(761, 604);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 44);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Gray;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = Properties.Resources.Task;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(615, 604);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(131, 44);
            btnNuevo.TabIndex = 21;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // cmbTipoSangre
            // 
            cmbTipoSangre.FormattingEnabled = true;
            cmbTipoSangre.Items.AddRange(new object[] { "<Seleccione>", "O+", "O-", "A+ ", "A- ", "B+", "B-", "AB+", "AB-" });
            cmbTipoSangre.Location = new Point(619, 241);
            cmbTipoSangre.Margin = new Padding(3, 4, 3, 4);
            cmbTipoSangre.Name = "cmbTipoSangre";
            cmbTipoSangre.Size = new Size(273, 28);
            cmbTipoSangre.TabIndex = 20;
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Location = new Point(615, 468);
            txtEnfermedades.Margin = new Padding(3, 4, 3, 4);
            txtEnfermedades.Multiline = true;
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(275, 109);
            txtEnfermedades.TabIndex = 19;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(617, 301);
            txtAlergias.Margin = new Padding(3, 4, 3, 4);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(275, 131);
            txtAlergias.TabIndex = 18;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(161, 468);
            txtAltura.Margin = new Padding(3, 4, 3, 4);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(282, 27);
            txtAltura.TabIndex = 15;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(161, 407);
            txtPeso.Margin = new Padding(3, 4, 3, 4);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(282, 27);
            txtPeso.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(161, 353);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(282, 27);
            txtTelefono.TabIndex = 13;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(161, 297);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(282, 27);
            txtApellidos.TabIndex = 12;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(161, 237);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(282, 27);
            txtNombres.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(356, 159);
            label10.Name = "label10";
            label10.Size = new Size(210, 32);
            label10.TabIndex = 10;
            label10.Text = "Agregar Paciente";
            label10.Click += label10_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 35);
            panel2.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(893, 0);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(32, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(471, 465);
            label9.Name = "label9";
            label9.Size = new Size(146, 28);
            label9.TabIndex = 8;
            label9.Text = "Enfermedades";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(528, 304);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 7;
            label8.Text = "Alergias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(471, 239);
            label7.Name = "label7";
            label7.Size = new Size(154, 28);
            label7.TabIndex = 6;
            label7.Text = "Tipo de Sangre";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(5, 508);
            label6.Name = "label6";
            label6.Size = new Size(155, 59);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Nacimiento";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(70, 465);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 4;
            label5.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(82, 405);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 356);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 297);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 235);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // Agregar_Paciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 705);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Agregar_Paciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Paciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox txtPeso;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private Label label10;
        private TextBox txtAltura;
        private Button btnGuardar;
        private Button btnNuevo;
        private ComboBox cmbTipoSangre;
        private TextBox txtEnfermedades;
        private TextBox txtAlergias;
        private ComboBox cmbGenero;
        private Label label11;
        private TextBox txtCorreo;
        private Label label12;
        private DateTimePicker dtpNacimiento;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}