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
            pnltool = new Panel();
            btnSalir = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbNombreMedic = new Label();
            lnApellidos = new Label();
            pnl_Fondo.SuspendLayout();
            pnltool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_Fondo
            // 
            pnl_Fondo.BackColor = Color.FromArgb(0, 122, 204);
            pnl_Fondo.Controls.Add(lnApellidos);
            pnl_Fondo.Controls.Add(lbNombreMedic);
            pnl_Fondo.Controls.Add(pnltool);
            pnl_Fondo.Controls.Add(button3);
            pnl_Fondo.Controls.Add(button2);
            pnl_Fondo.Controls.Add(button1);
            pnl_Fondo.Controls.Add(txtApellidos);
            pnl_Fondo.Controls.Add(txtNombres);
            pnl_Fondo.Controls.Add(pictureBox1);
            pnl_Fondo.Controls.Add(label1);
            pnl_Fondo.Dock = DockStyle.Fill;
            pnl_Fondo.Location = new Point(0, 0);
            pnl_Fondo.Name = "pnl_Fondo";
            pnl_Fondo.Size = new Size(275, 425);
            pnl_Fondo.TabIndex = 0;
            // 
            // pnltool
            // 
            pnltool.BackColor = SystemColors.ButtonShadow;
            pnltool.Controls.Add(btnSalir);
            pnltool.Dock = DockStyle.Top;
            pnltool.Location = new Point(0, 0);
            pnltool.Name = "pnltool";
            pnltool.Size = new Size(275, 20);
            pnltool.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(244, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(31, 20);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button3
            // 
            button3.Location = new Point(92, 381);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(92, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(92, 323);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(31, 263);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(213, 23);
            txtApellidos.TabIndex = 3;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(31, 209);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(213, 23);
            txtNombres.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Medical_Doctor;
            pictureBox1.Location = new Point(92, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 83);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 39);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Medico";
            // 
            // lbNombreMedic
            // 
            lbNombreMedic.AutoSize = true;
            lbNombreMedic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreMedic.ForeColor = Color.White;
            lbNombreMedic.Location = new Point(31, 189);
            lbNombreMedic.Name = "lbNombreMedic";
            lbNombreMedic.Size = new Size(64, 17);
            lbNombreMedic.TabIndex = 10;
            lbNombreMedic.Text = "Nombres";
            // 
            // lnApellidos
            // 
            lnApellidos.AutoSize = true;
            lnApellidos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnApellidos.ForeColor = Color.White;
            lnApellidos.Location = new Point(31, 243);
            lnApellidos.Name = "lnApellidos";
            lnApellidos.Size = new Size(66, 17);
            lnApellidos.TabIndex = 11;
            lnApellidos.Text = "Apellidos";
            // 
            // Agregar_Medico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 425);
            Controls.Add(pnl_Fondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_Medico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Medico";
            pnl_Fondo.ResumeLayout(false);
            pnl_Fondo.PerformLayout();
            pnltool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Fondo;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnltool;
        private Button btnSalir;
        private Label lnApellidos;
        private Label lbNombreMedic;
    }
}