
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
            lblSaludo = new Label();
            btnUsuario = new Button();
            pnlMenu = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            btnAggEspecialidad = new Button();
            btnAggPac = new Button();
            btnAggMed = new Button();
            btnMenu = new Button();
            pnlHerramienta = new Panel();
            btnSalir = new Button();
            panel1 = new Panel();
            lbWelcome = new Label();
            pictureBox1 = new PictureBox();
            timerMostrarSaludo = new System.Windows.Forms.Timer(components);
            timerOcultarSaludo = new System.Windows.Forms.Timer(components);
            pnlFondo.SuspendLayout();
            pnlMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlHerramienta.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = Color.White;
            pnlFondo.Controls.Add(lblSaludo);
            pnlFondo.Controls.Add(btnUsuario);
            pnlFondo.Controls.Add(pnlMenu);
            pnlFondo.Controls.Add(pnlHerramienta);
            pnlFondo.Controls.Add(panel1);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 0);
            pnlFondo.Margin = new Padding(3, 4, 3, 4);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(914, 600);
            pnlFondo.TabIndex = 0;
            // 
            // lblSaludo
            // 
            lblSaludo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaludo.ForeColor = Color.Black;
            lblSaludo.Location = new Point(601, 47);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(259, 28);
            lblSaludo.TabIndex = 3;
            lblSaludo.Text = "label1";
            lblSaludo.TextAlign = ContentAlignment.MiddleRight;
            lblSaludo.Visible = false;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Image = Properties.Resources.Icons1;
            btnUsuario.Location = new Point(859, 32);
            btnUsuario.Margin = new Padding(3, 4, 3, 4);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(55, 63);
            btnUsuario.TabIndex = 2;
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.LightSkyBlue;
            pnlMenu.Controls.Add(panel2);
            pnlMenu.Controls.Add(btnAggEspecialidad);
            pnlMenu.Controls.Add(btnAggPac);
            pnlMenu.Controls.Add(btnAggMed);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 32);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(234, 568);
            pnlMenu.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 234);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightSkyBlue;
            pictureBox2.Image = Properties.Resources.medico;
            pictureBox2.Location = new Point(41, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnAggEspecialidad
            // 
            btnAggEspecialidad.BackColor = Color.LightSkyBlue;
            btnAggEspecialidad.Dock = DockStyle.Top;
            btnAggEspecialidad.FlatAppearance.BorderSize = 0;
            btnAggEspecialidad.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnAggEspecialidad.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnAggEspecialidad.FlatStyle = FlatStyle.Flat;
            btnAggEspecialidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggEspecialidad.ForeColor = Color.Black;
            btnAggEspecialidad.Location = new Point(0, 243);
            btnAggEspecialidad.Name = "btnAggEspecialidad";
            btnAggEspecialidad.Size = new Size(234, 81);
            btnAggEspecialidad.TabIndex = 3;
            btnAggEspecialidad.Text = "Agregar Especialidad";
            btnAggEspecialidad.UseVisualStyleBackColor = false;
            btnAggEspecialidad.Click += btnAggEspecialidad_Click;
            // 
            // btnAggPac
            // 
            btnAggPac.BackColor = Color.LightSkyBlue;
            btnAggPac.Dock = DockStyle.Top;
            btnAggPac.FlatAppearance.BorderSize = 0;
            btnAggPac.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnAggPac.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnAggPac.FlatStyle = FlatStyle.Flat;
            btnAggPac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggPac.ForeColor = Color.Black;
            btnAggPac.Location = new Point(0, 162);
            btnAggPac.Name = "btnAggPac";
            btnAggPac.Size = new Size(234, 81);
            btnAggPac.TabIndex = 2;
            btnAggPac.Text = "Agregar Paciente";
            btnAggPac.UseVisualStyleBackColor = false;
            btnAggPac.Click += btnAggPac_Click;
            // 
            // btnAggMed
            // 
            btnAggMed.BackColor = Color.LightSkyBlue;
            btnAggMed.Dock = DockStyle.Top;
            btnAggMed.FlatAppearance.BorderSize = 0;
            btnAggMed.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnAggMed.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnAggMed.FlatStyle = FlatStyle.Flat;
            btnAggMed.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggMed.ForeColor = Color.Black;
            btnAggMed.Location = new Point(0, 81);
            btnAggMed.Name = "btnAggMed";
            btnAggMed.Size = new Size(234, 81);
            btnAggMed.TabIndex = 1;
            btnAggMed.Text = "Agregar Médico";
            btnAggMed.UseVisualStyleBackColor = false;
            btnAggMed.Click += btnAggMed_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(0, 122, 204);
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnMenu.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(234, 81);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlHerramienta
            // 
            pnlHerramienta.BackColor = SystemColors.ButtonShadow;
            pnlHerramienta.Controls.Add(btnSalir);
            pnlHerramienta.Dock = DockStyle.Top;
            pnlHerramienta.Location = new Point(0, 0);
            pnlHerramienta.Margin = new Padding(3, 4, 3, 4);
            pnlHerramienta.Name = "pnlHerramienta";
            pnlHerramienta.Size = new Size(914, 32);
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
            btnSalir.Location = new Point(882, 0);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(32, 32);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(240, 88);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 508);
            panel1.TabIndex = 0;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.BackColor = Color.White;
            lbWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.ForeColor = Color.FromArgb(0, 122, 204);
            lbWelcome.Location = new Point(74, 25);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(524, 46);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "Bienvenido a tu centro de salud\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGOMENU;
            pictureBox1.Location = new Point(106, 97);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlFondo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlFondo.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlHerramienta.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label lbWelcome;
        private Button btnSalir;
        private Button btnMenu;
        private Panel panel1;
        private Button btnAggEspecialidad;
        private Button btnAggPac;
        private Button btnAggMed;
        private Label lblSaludo;
        private Button btnUsuario;
        private System.Windows.Forms.Timer timerMostrarSaludo;
        private System.Windows.Forms.Timer timerOcultarSaludo;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}