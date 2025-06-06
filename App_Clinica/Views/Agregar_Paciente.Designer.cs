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
            btnEditar = new Button();
            btnEstado = new Button();
            dgvPaciente = new DataGridView();
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
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnEstado);
            panel1.Controls.Add(dgvPaciente);
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
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 547);
            panel1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DimGray;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(876, 502);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 33);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEstado
            // 
            btnEstado.BackColor = Color.DimGray;
            btnEstado.FlatStyle = FlatStyle.Flat;
            btnEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEstado.ForeColor = Color.White;
            btnEstado.Location = new Point(713, 502);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(142, 33);
            btnEstado.TabIndex = 32;
            btnEstado.Text = "Modificar estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // dgvPaciente
            // 
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Location = new Point(714, 159);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.Size = new Size(660, 337);
            dgvPaciente.TabIndex = 31;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.CalendarForeColor = Color.DimGray;
            dtpNacimiento.CalendarMonthBackground = Color.WhiteSmoke;
            dtpNacimiento.CalendarTitleBackColor = Color.DodgerBlue;
            dtpNacimiento.CalendarTitleForeColor = Color.WhiteSmoke;
            dtpNacimiento.CalendarTrailingForeColor = Color.LightGray;
            dtpNacimiento.Location = new Point(141, 392);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(159, 23);
            dtpNacimiento.TabIndex = 28;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.WhiteSmoke;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.DimGray;
            txtCorreo.Location = new Point(141, 477);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(159, 23);
            txtCorreo.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(25, 118, 210);
            label12.Location = new Point(57, 475);
            label12.Name = "label12";
            label12.Size = new Size(61, 21);
            label12.TabIndex = 26;
            label12.Text = "Correo";
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.WhiteSmoke;
            cmbGenero.FlatStyle = FlatStyle.Flat;
            cmbGenero.ForeColor = Color.DimGray;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino ", "Femenino" });
            cmbGenero.Location = new Point(141, 437);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(159, 23);
            cmbGenero.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(25, 118, 210);
            label11.Location = new Point(57, 439);
            label11.Name = "label11";
            label11.Size = new Size(65, 21);
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
            btnGuardar.Location = new Point(560, 439);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 33);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "     Guardar";
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
            btnNuevo.Location = new Point(432, 439);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(115, 33);
            btnNuevo.TabIndex = 21;
            btnNuevo.Text = "     Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // cmbTipoSangre
            // 
            cmbTipoSangre.BackColor = Color.WhiteSmoke;
            cmbTipoSangre.FlatStyle = FlatStyle.Flat;
            cmbTipoSangre.ForeColor = Color.DimGray;
            cmbTipoSangre.FormattingEnabled = true;
            cmbTipoSangre.Items.AddRange(new object[] { "O+", "O-", "A+ ", "A- ", "B+", "B-", "AB+", "AB-" });
            cmbTipoSangre.Location = new Point(436, 180);
            cmbTipoSangre.Name = "cmbTipoSangre";
            cmbTipoSangre.Size = new Size(239, 23);
            cmbTipoSangre.TabIndex = 20;
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.BackColor = Color.WhiteSmoke;
            txtEnfermedades.BorderStyle = BorderStyle.FixedSingle;
            txtEnfermedades.ForeColor = Color.DimGray;
            txtEnfermedades.Location = new Point(432, 350);
            txtEnfermedades.Multiline = true;
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(241, 83);
            txtEnfermedades.TabIndex = 19;
            // 
            // txtAlergias
            // 
            txtAlergias.BackColor = Color.WhiteSmoke;
            txtAlergias.BorderStyle = BorderStyle.FixedSingle;
            txtAlergias.ForeColor = Color.DimGray;
            txtAlergias.Location = new Point(434, 225);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(241, 99);
            txtAlergias.TabIndex = 18;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = Color.WhiteSmoke;
            txtAltura.BorderStyle = BorderStyle.FixedSingle;
            txtAltura.Location = new Point(141, 351);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(159, 23);
            txtAltura.TabIndex = 15;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.WhiteSmoke;
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.ForeColor = Color.DimGray;
            txtPeso.Location = new Point(141, 305);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(159, 23);
            txtPeso.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.DimGray;
            txtTelefono.Location = new Point(141, 265);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(159, 23);
            txtTelefono.TabIndex = 13;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.WhiteSmoke;
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.ForeColor = Color.DimGray;
            txtApellidos.Location = new Point(141, 223);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(159, 23);
            txtApellidos.TabIndex = 12;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.WhiteSmoke;
            txtNombres.BorderStyle = BorderStyle.FixedSingle;
            txtNombres.ForeColor = Color.DimGray;
            txtNombres.Location = new Point(141, 178);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(159, 23);
            txtNombres.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 242, 253);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 26);
            panel2.TabIndex = 9;
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
            btnSalir.Location = new Point(1144, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(28, 26);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(25, 118, 210);
            label9.Location = new Point(306, 348);
            label9.Name = "label9";
            label9.Size = new Size(119, 21);
            label9.TabIndex = 8;
            label9.Text = "Enfermedades";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(25, 118, 210);
            label8.Location = new Point(356, 227);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 7;
            label8.Text = "Alergias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(25, 118, 210);
            label7.Location = new Point(306, 178);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 6;
            label7.Text = "Tipo de Sangre";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(25, 118, 210);
            label6.Location = new Point(4, 381);
            label6.Name = "label6";
            label6.Size = new Size(136, 44);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Nacimiento";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(25, 118, 210);
            label5.Location = new Point(61, 349);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 4;
            label5.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(25, 118, 210);
            label4.Location = new Point(72, 304);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(25, 118, 210);
            label3.Location = new Point(46, 267);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(25, 118, 210);
            label2.Location = new Point(43, 223);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(25, 118, 210);
            label1.Location = new Point(46, 176);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(227, 242, 253);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(0, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(1386, 130);
            panel3.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(227, 242, 253);
            pictureBox1.Image = Properties.Resources.Stethoscope;
            pictureBox1.Location = new Point(616, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 70);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(227, 242, 253);
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(25, 118, 210);
            label10.Location = new Point(575, 86);
            label10.Name = "label10";
            label10.Size = new Size(165, 25);
            label10.TabIndex = 10;
            label10.Text = "Agregar Paciente";
            // 
            // Agregar_Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 547);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_Paciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Paciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel3;
        private DataGridView dgvPaciente;
        private Button btnEditar;
        private Button btnEstado;
    }
}