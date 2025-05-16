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
            pnlFondo = new Panel();
            pnlMenu = new Panel();
            imgMenu = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btn_AggMedic = new Button();
            pnlHerramienta = new Panel();
            btnSalir = new Button();
            panel1 = new Panel();
            lb1 = new Label();
            lbWelcome = new Label();
            pictureBox1 = new PictureBox();
            pnlFondo.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenu).BeginInit();
            pnlHerramienta.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = SystemColors.ButtonFace;
            pnlFondo.Controls.Add(pnlMenu);
            pnlFondo.Controls.Add(pnlHerramienta);
            pnlFondo.Controls.Add(panel1);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 0);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(800, 450);
            pnlFondo.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(0, 122, 204);
            pnlMenu.Controls.Add(imgMenu);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(btn_AggMedic);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 24);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(205, 426);
            pnlMenu.TabIndex = 1;
            // 
            // imgMenu
            // 
            imgMenu.Location = new Point(3, 3);
            imgMenu.Name = "imgMenu";
            imgMenu.Size = new Size(24, 25);
            imgMenu.TabIndex = 4;
            imgMenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 3);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 264);
            button4.Name = "button4";
            button4.Size = new Size(205, 51);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 207);
            button3.Name = "button3";
            button3.Size = new Size(205, 51);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 150);
            button2.Name = "button2";
            button2.Size = new Size(205, 51);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_AggMedic
            // 
            btn_AggMedic.FlatAppearance.BorderSize = 0;
            btn_AggMedic.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_AggMedic.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btn_AggMedic.FlatStyle = FlatStyle.Flat;
            btn_AggMedic.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_AggMedic.ForeColor = Color.White;
            btn_AggMedic.Location = new Point(0, 93);
            btn_AggMedic.Name = "btn_AggMedic";
            btn_AggMedic.Size = new Size(205, 51);
            btn_AggMedic.TabIndex = 1;
            btn_AggMedic.Text = "Agregar Medico";
            btn_AggMedic.UseVisualStyleBackColor = true;
            btn_AggMedic.Click += btn_AggMedic_Click;
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
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenu).EndInit();
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
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btn_AggMedic;
        private PictureBox pictureBox1;
        private Label lb1;
        private Label lbWelcome;
        private PictureBox imgMenu;
        private Label label1;
        private Button btnSalir;
    }
}