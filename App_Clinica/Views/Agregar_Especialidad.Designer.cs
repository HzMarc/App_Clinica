namespace App_Clinica.Views
{
    partial class Agregar_Especialidad
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
            label1 = new Label();
            label2 = new Label();
            txtNombreEspecialidad = new TextBox();
            txtDescripcionEspecialidad = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            btnEditar = new Button();
            btnEstado = new Button();
            dgvEspecialidad = new DataGridView();
            btnNew = new Button();
            btnGuardar = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pnltool = new Panel();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnltool.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 118, 210);
            label1.Location = new Point(24, 160);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 77;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(25, 118, 210);
            label2.Location = new Point(24, 225);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 78;
            label2.Text = "Descripción";
            // 
            // txtNombreEspecialidad
            // 
            txtNombreEspecialidad.BackColor = Color.WhiteSmoke;
            txtNombreEspecialidad.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEspecialidad.ForeColor = Color.DimGray;
            txtNombreEspecialidad.Location = new Point(24, 183);
            txtNombreEspecialidad.Margin = new Padding(3, 2, 3, 2);
            txtNombreEspecialidad.Multiline = true;
            txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            txtNombreEspecialidad.Size = new Size(277, 26);
            txtNombreEspecialidad.TabIndex = 1;
            // 
            // txtDescripcionEspecialidad
            // 
            txtDescripcionEspecialidad.BackColor = Color.WhiteSmoke;
            txtDescripcionEspecialidad.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionEspecialidad.ForeColor = Color.DimGray;
            txtDescripcionEspecialidad.Location = new Point(24, 248);
            txtDescripcionEspecialidad.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionEspecialidad.Multiline = true;
            txtDescripcionEspecialidad.Name = "txtDescripcionEspecialidad";
            txtDescripcionEspecialidad.Size = new Size(277, 98);
            txtDescripcionEspecialidad.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnltool);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombreEspecialidad);
            panel1.Controls.Add(txtDescripcionEspecialidad);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 495);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(233, 233, 233);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnEstado);
            panel3.Controls.Add(dgvEspecialidad);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(408, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(556, 360);
            panel3.TabIndex = 79;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DimGray;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(182, 315);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 33);
            btnEditar.TabIndex = 15;
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
            btnEstado.Location = new Point(19, 315);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(142, 33);
            btnEstado.TabIndex = 14;
            btnEstado.Text = "Modificar estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // dgvEspecialidad
            // 
            dgvEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidad.Location = new Point(19, 39);
            dgvEspecialidad.Name = "dgvEspecialidad";
            dgvEspecialidad.Size = new Size(525, 270);
            dgvEspecialidad.TabIndex = 13;
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
            btnNew.Location = new Point(24, 360);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 33);
            btnNew.TabIndex = 4;
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
            btnGuardar.Location = new Point(172, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(129, 33);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "     Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 242, 253);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 106);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Doctors_Bag;
            pictureBox1.Location = new Point(472, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 71);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(227, 242, 253);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(25, 118, 210);
            label3.Location = new Point(427, 82);
            label3.Name = "label3";
            label3.Size = new Size(171, 21);
            label3.TabIndex = 0;
            label3.Text = "Agregar Especialidad";
            // 
            // pnltool
            // 
            pnltool.BackColor = Color.FromArgb(227, 242, 253);
            pnltool.Controls.Add(btnSalir);
            pnltool.Dock = DockStyle.Top;
            pnltool.Location = new Point(0, 0);
            pnltool.Name = "pnltool";
            pnltool.Size = new Size(964, 29);
            pnltool.TabIndex = 10;
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
            btnSalir.Location = new Point(933, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(31, 29);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Agregar_Especialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 495);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Agregar_Especialidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Especialidad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnltool.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreEspecialidad;
        private TextBox txtDescripcionEspecialidad;
        private Panel panel1;
        private Label label3;
        private Panel pnltool;
        private Button btnSalir;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnNew;
        private Button btnGuardar;
        private Panel panel3;
        private Button btnEditar;
        private Button btnEstado;
        private DataGridView dgvEspecialidad;
    }
}