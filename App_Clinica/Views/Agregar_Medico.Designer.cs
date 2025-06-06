namespace App_Clinica.Views
{
    partial class Agregar_Medico
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
            pnl_Fondo = new Panel();
            panel2 = new Panel();
            btnEditar = new Button();
            btnEstado = new Button();
            dgvMedico = new DataGridView();
            btnNew = new Button();
            btnGuardar = new Button();
            cmbEspecialidad = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            lnApellidos = new Label();
            lbNombreMedic = new Label();
            pnltool = new Panel();
            btnSalir = new Button();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnl_Fondo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedico).BeginInit();
            pnltool.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_Fondo
            // 
            pnl_Fondo.BackColor = Color.White;
            pnl_Fondo.Controls.Add(panel2);
            pnl_Fondo.Controls.Add(btnNew);
            pnl_Fondo.Controls.Add(btnGuardar);
            pnl_Fondo.Controls.Add(cmbEspecialidad);
            pnl_Fondo.Controls.Add(label4);
            pnl_Fondo.Controls.Add(label3);
            pnl_Fondo.Controls.Add(txtTelefono);
            pnl_Fondo.Controls.Add(label2);
            pnl_Fondo.Controls.Add(txtCorreo);
            pnl_Fondo.Controls.Add(lnApellidos);
            pnl_Fondo.Controls.Add(lbNombreMedic);
            pnl_Fondo.Controls.Add(pnltool);
            pnl_Fondo.Controls.Add(txtApellidos);
            pnl_Fondo.Controls.Add(txtNombres);
            pnl_Fondo.Controls.Add(panel1);
            pnl_Fondo.Dock = DockStyle.Fill;
            pnl_Fondo.Location = new Point(0, 0);
            pnl_Fondo.Name = "pnl_Fondo";
            pnl_Fondo.Size = new Size(1128, 537);
            pnl_Fondo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(233, 233, 233);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnEstado);
            panel2.Controls.Add(dgvMedico);
            panel2.Location = new Point(276, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 379);
            panel2.TabIndex = 21;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DimGray;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(175, 334);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 33);
            btnEditar.TabIndex = 17;
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
            btnEstado.Location = new Point(12, 334);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(142, 33);
            btnEstado.TabIndex = 16;
            btnEstado.Text = "Modificar estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // dgvMedico
            // 
            dgvMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedico.Location = new Point(13, 25);
            dgvMedico.Name = "dgvMedico";
            dgvMedico.Size = new Size(824, 303);
            dgvMedico.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Gray;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNew.ForeColor = Color.White;
            btnNew.Image = Properties.Resources.Task;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(31, 492);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(101, 33);
            btnNew.TabIndex = 20;
            btnNew.Text = "    Nuevo";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gray;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources.Save;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(143, 492);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 33);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "     Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.BackColor = Color.WhiteSmoke;
            cmbEspecialidad.FlatStyle = FlatStyle.Flat;
            cmbEspecialidad.ForeColor = Color.DimGray;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(31, 447);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(213, 23);
            cmbEspecialidad.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(25, 118, 210);
            label4.Location = new Point(31, 427);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 16;
            label4.Text = "Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(25, 118, 210);
            label3.Location = new Point(31, 364);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 15;
            label3.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.DimGray;
            txtTelefono.Location = new Point(31, 384);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(213, 23);
            txtTelefono.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(25, 118, 210);
            label2.Location = new Point(31, 308);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 13;
            label2.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.WhiteSmoke;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.DimGray;
            txtCorreo.Location = new Point(31, 328);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(213, 23);
            txtCorreo.TabIndex = 12;
            // 
            // lnApellidos
            // 
            lnApellidos.AutoSize = true;
            lnApellidos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnApellidos.ForeColor = Color.FromArgb(25, 118, 210);
            lnApellidos.Location = new Point(31, 243);
            lnApellidos.Name = "lnApellidos";
            lnApellidos.Size = new Size(66, 17);
            lnApellidos.TabIndex = 11;
            lnApellidos.Text = "Apellidos";
            // 
            // lbNombreMedic
            // 
            lbNombreMedic.AutoSize = true;
            lbNombreMedic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreMedic.ForeColor = Color.FromArgb(25, 118, 210);
            lbNombreMedic.Location = new Point(31, 180);
            lbNombreMedic.Name = "lbNombreMedic";
            lbNombreMedic.Size = new Size(64, 17);
            lbNombreMedic.TabIndex = 10;
            lbNombreMedic.Text = "Nombres";
            // 
            // pnltool
            // 
            pnltool.BackColor = Color.FromArgb(227, 242, 253);
            pnltool.Controls.Add(btnSalir);
            pnltool.Dock = DockStyle.Top;
            pnltool.Location = new Point(0, 0);
            pnltool.Name = "pnltool";
            pnltool.Size = new Size(1128, 29);
            pnltool.TabIndex = 9;
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
            btnSalir.Location = new Point(1097, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(31, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.WhiteSmoke;
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.ForeColor = Color.DimGray;
            txtApellidos.Location = new Point(31, 263);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(213, 23);
            txtApellidos.TabIndex = 3;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.WhiteSmoke;
            txtNombres.BorderStyle = BorderStyle.FixedSingle;
            txtNombres.ForeColor = Color.DimGray;
            txtNombres.Location = new Point(31, 200);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(213, 23);
            txtNombres.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 134);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(227, 242, 253);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 118, 210);
            label1.Location = new Point(503, 100);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Médico ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Doctor_Skin_Type_2;
            pictureBox1.Location = new Point(526, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 87);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Agregar_Medico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 537);
            Controls.Add(pnl_Fondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_Medico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Medico";
            pnl_Fondo.ResumeLayout(false);
            pnl_Fondo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedico).EndInit();
            pnltool.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Fondo;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnltool;
        private Button btnSalir;
        private Label lnApellidos;
        private Label lbNombreMedic;
        private Label label3;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtCorreo;
        private ComboBox cmbEspecialidad;
        private Label label4;
        private Panel panel1;
        private Button btnNew;
        private Button btnGuardar;
        private Panel panel2;
        private DataGridView dgvMedico;
        private Button btnEditar;
        private Button btnEstado;
    }
}