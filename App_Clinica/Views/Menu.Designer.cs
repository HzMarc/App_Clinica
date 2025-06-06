
namespace App_Clinica.Views
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            pnlFondo = new Panel();
            panel1 = new Panel();
            lb1 = new Label();
            lbWelcome = new Label();
            pictureBox1 = new PictureBox();
            lblSaludo = new Label();
            btnUsuario = new Button();
            pnlMenu = new Panel();
            btnAggEspecialidad = new Button();
            btnAggPac = new Button();
            btnAggMed = new Button();
            btnMenu = new Button();
            pnlHerramienta = new Panel();
            btnSalir = new Button();
            timerMostrarSaludo = new System.Windows.Forms.Timer(components);
            timerOcultarSaludo = new System.Windows.Forms.Timer(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlFondo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMenu.SuspendLayout();
            pnlHerramienta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = Color.Black;
            pnlFondo.Controls.Add(panel1);
            pnlFondo.Controls.Add(lblSaludo);
            pnlFondo.Controls.Add(btnUsuario);
            pnlFondo.Controls.Add(pnlMenu);
            pnlFondo.Controls.Add(pnlHerramienta);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 0);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(800, 450);
            pnlFondo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(lb1);
            panel1.Controls.Add(lbWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(325, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 302);
            panel1.TabIndex = 4;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.ForeColor = Color.FromArgb(0, 122, 204);
            lb1.Location = new Point(97, 225);
            lb1.Name = "lb1";
            lb1.Size = new Size(220, 21);
            lb1.TabIndex = 2;
            lb1.Text = "Estamos aquí para cuidarte.";
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.ForeColor = Color.FromArgb(0, 122, 204);
            lbWelcome.Location = new Point(36, 40);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(331, 21);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "Bienvenido a tu centro de salud MEDCARE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Azul1__1_;
            pictureBox1.Location = new Point(120, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 147);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSaludo
            // 
            lblSaludo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaludo.ForeColor = Color.White;
            lblSaludo.Location = new Point(519, 36);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(227, 35);
            lblSaludo.TabIndex = 3;
            lblSaludo.Text = "label1";
            lblSaludo.TextAlign = ContentAlignment.MiddleRight;
            lblSaludo.Visible = false;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Image = Properties.Resources.Male_User1;
            btnUsuario.Location = new Point(752, 24);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(48, 47);
            btnUsuario.TabIndex = 2;
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(0, 122, 204);
            pnlMenu.Controls.Add(btnAggEspecialidad);
            pnlMenu.Controls.Add(btnAggPac);
            pnlMenu.Controls.Add(btnAggMed);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 24);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(205, 426);
            pnlMenu.TabIndex = 1;
            // 
            // btnAggEspecialidad
            // 
            btnAggEspecialidad.BackColor = Color.FromArgb(0, 122, 204);
            btnAggEspecialidad.FlatAppearance.BorderSize = 0;
            btnAggEspecialidad.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnAggEspecialidad.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAggEspecialidad.FlatStyle = FlatStyle.Flat;
            btnAggEspecialidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggEspecialidad.ForeColor = Color.White;
            btnAggEspecialidad.Location = new Point(3, 251);
            btnAggEspecialidad.Margin = new Padding(3, 2, 3, 2);
            btnAggEspecialidad.Name = "btnAggEspecialidad";
            btnAggEspecialidad.Size = new Size(205, 61);
            btnAggEspecialidad.TabIndex = 3;
            btnAggEspecialidad.Text = "Agregar Especialidad";
            btnAggEspecialidad.UseVisualStyleBackColor = false;
            btnAggEspecialidad.Click += btnAggEspecialidad_Click;
            // 
            // btnAggPac
            // 
            btnAggPac.BackColor = Color.FromArgb(0, 122, 204);
            btnAggPac.FlatAppearance.BorderSize = 0;
            btnAggPac.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnAggPac.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAggPac.FlatStyle = FlatStyle.Flat;
            btnAggPac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggPac.ForeColor = Color.White;
            btnAggPac.Location = new Point(0, 186);
            btnAggPac.Margin = new Padding(3, 2, 3, 2);
            btnAggPac.Name = "btnAggPac";
            btnAggPac.Size = new Size(205, 61);
            btnAggPac.TabIndex = 2;
            btnAggPac.Text = "Agregar Paciente";
            btnAggPac.UseVisualStyleBackColor = false;
            btnAggPac.Click += btnAggPac_Click;
            // 
            // btnAggMed
            // 
            btnAggMed.BackColor = Color.FromArgb(0, 122, 204);
            btnAggMed.FlatAppearance.BorderSize = 0;
            btnAggMed.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnAggMed.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAggMed.FlatStyle = FlatStyle.Flat;
            btnAggMed.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggMed.ForeColor = Color.White;
            btnAggMed.Location = new Point(3, 121);
            btnAggMed.Margin = new Padding(3, 2, 3, 2);
            btnAggMed.Name = "btnAggMed";
            btnAggMed.Size = new Size(205, 61);
            btnAggMed.TabIndex = 1;
            btnAggMed.Text = "Agregar Médico";
            btnAggMed.UseVisualStyleBackColor = false;
            btnAggMed.Click += btnAggMed_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(0, 122, 204);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnMenu.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Image = Properties.Resources.mrdHome;
            btnMenu.ImageAlign = ContentAlignment.TopLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(205, 61);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlHerramienta
            // 
            pnlHerramienta.BackColor = Color.FromArgb(0, 122, 204);
            pnlHerramienta.Controls.Add(btnSalir);
            pnlHerramienta.Dock = DockStyle.Top;
            pnlHerramienta.Location = new Point(0, 0);
            pnlHerramienta.Name = "pnlHerramienta";
            pnlHerramienta.Size = new Size(800, 24);
            pnlHerramienta.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(772, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(28, 24);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // timerMostrarSaludo
            // 
            timerMostrarSaludo.Interval = 500;
            timerMostrarSaludo.Tick += timerMostrarSaludo_Tick;
            // 
            // timerOcultarSaludo
            // 
            timerOcultarSaludo.Interval = 1000;
            timerOcultarSaludo.Tick += timerOcultarSaludo_Tick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlFondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlFondo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlHerramienta.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel pnlFondo;
        private Panel pnlMenu;
        private Panel pnlHerramienta;
        private Button btnSalir;
        private Button btnMenu;
        private Button btnAggEspecialidad;
        private Button btnAggPac;
        private Button btnAggMed;
        private Label lblSaludo;
        private Button btnUsuario;
        private System.Windows.Forms.Timer timerMostrarSaludo;
        private System.Windows.Forms.Timer timerOcultarSaludo;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Label lb1;
        private Label lbWelcome;
        private PictureBox pictureBox1;
    }
}