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
            button5 = new Button();
            button4 = new Button();
            btnAggPac = new Button();
            btnAggMed = new Button();
            btnMenu = new Button();
            pnlHerramienta = new Panel();
            btnSalir = new Button();
            panel1 = new Panel();
            lb1 = new Label();
            lbWelcome = new Label();
            pictureBox1 = new PictureBox();
            timerMostrarSaludo = new System.Windows.Forms.Timer(components);
            timerOcultarSaludo = new System.Windows.Forms.Timer(components);
            pnlFondo.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlHerramienta.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = SystemColors.ButtonFace;
            pnlFondo.Controls.Add(lblSaludo);
            pnlFondo.Controls.Add(btnUsuario);
            pnlFondo.Controls.Add(pnlMenu);
            pnlFondo.Controls.Add(pnlHerramienta);
            pnlFondo.Controls.Add(panel1);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 0);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(800, 450);
            pnlFondo.TabIndex = 0;
            // 
            // lblSaludo
            // 
            lblSaludo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaludo.ForeColor = Color.DimGray;
            lblSaludo.Location = new Point(526, 35);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(227, 21);
            lblSaludo.TabIndex = 3;
            lblSaludo.Text = "label1";
            lblSaludo.TextAlign = ContentAlignment.MiddleRight;
            lblSaludo.Visible = false;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Image = Properties.Resources.Male_User;
            btnUsuario.Location = new Point(752, 24);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(48, 47);
            btnUsuario.TabIndex = 2;
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(0, 122, 204);
            pnlMenu.Controls.Add(button5);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(btnAggPac);
            pnlMenu.Controls.Add(btnAggMed);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 24);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(205, 426);
            pnlMenu.TabIndex = 1;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button5.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 168);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(205, 42);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 126);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(205, 42);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnAggPac
            // 
            btnAggPac.Dock = DockStyle.Top;
            btnAggPac.FlatAppearance.BorderSize = 0;
            btnAggPac.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnAggPac.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnAggPac.FlatStyle = FlatStyle.Flat;
            btnAggPac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggPac.ForeColor = Color.White;
            btnAggPac.Location = new Point(0, 84);
            btnAggPac.Margin = new Padding(3, 2, 3, 2);
            btnAggPac.Name = "btnAggPac";
            btnAggPac.Size = new Size(205, 42);
            btnAggPac.TabIndex = 2;
            btnAggPac.Text = "Agregar Paciente";
            btnAggPac.UseVisualStyleBackColor = true;
            btnAggPac.Click += btnAggPac_Click;
            // 
            // btnAggMed
            // 
            btnAggMed.Dock = DockStyle.Top;
            btnAggMed.FlatAppearance.BorderSize = 0;
            btnAggMed.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnAggMed.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnAggMed.FlatStyle = FlatStyle.Flat;
            btnAggMed.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAggMed.ForeColor = Color.White;
            btnAggMed.Location = new Point(0, 42);
            btnAggMed.Margin = new Padding(3, 2, 3, 2);
            btnAggMed.Name = "btnAggMed";
            btnAggMed.Size = new Size(205, 42);
            btnAggMed.TabIndex = 1;
            btnAggMed.Text = "Agregar Médico";
            btnAggMed.UseVisualStyleBackColor = true;
            btnAggMed.Click += btnAggMed_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnMenu.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(205, 42);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // pnlHerramienta
            // 
            pnlHerramienta.BackColor = SystemColors.ButtonShadow;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(lb1);
            panel1.Controls.Add(lbWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(325, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 266);
            panel1.TabIndex = 0;
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
            lbWelcome.Location = new Point(76, 33);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(255, 21);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "Bienvenido a tu centro de salud.";
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlFondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlFondo.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlHerramienta.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFondo;
        private Panel pnlMenu;
        private Panel pnlHerramienta;
        private PictureBox pictureBox1;
        private Label lb1;
        private Label lbWelcome;
        private Button btnSalir;
        private Button btnMenu;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button btnAggPac;
        private Button btnAggMed;
        private Label lblSaludo;
        private Button btnUsuario;
        private System.Windows.Forms.Timer timerMostrarSaludo;
        private System.Windows.Forms.Timer timerOcultarSaludo;
    }
}