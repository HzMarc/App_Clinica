namespace App_Clinica
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_Fondo = new Panel();
            picPass = new PictureBox();
            btnSee = new Button();
            picUser = new PictureBox();
            lb_Error = new Label();
            panel1 = new Panel();
            btn_Salir = new Button();
            linkLabel1 = new LinkLabel();
            btn_Login = new Button();
            lb_Iniciar = new Label();
            txt_Pass = new TextBox();
            txt_Usuario = new TextBox();
            lb_Usuario = new Label();
            lb_Pass = new Label();
            pnl_Lateral = new Panel();
            lb_Name_Clinica = new Label();
            img_Logo_Blanco = new PictureBox();
            pnl_Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            panel1.SuspendLayout();
            pnl_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Logo_Blanco).BeginInit();
            SuspendLayout();
            // 
            // pnl_Fondo
            // 
            pnl_Fondo.BackColor = Color.FromArgb(15, 15, 15);
            pnl_Fondo.Controls.Add(picPass);
            pnl_Fondo.Controls.Add(btnSee);
            pnl_Fondo.Controls.Add(picUser);
            pnl_Fondo.Controls.Add(lb_Error);
            pnl_Fondo.Controls.Add(panel1);
            pnl_Fondo.Controls.Add(linkLabel1);
            pnl_Fondo.Controls.Add(btn_Login);
            pnl_Fondo.Controls.Add(lb_Iniciar);
            pnl_Fondo.Controls.Add(txt_Pass);
            pnl_Fondo.Controls.Add(txt_Usuario);
            pnl_Fondo.Controls.Add(lb_Usuario);
            pnl_Fondo.Controls.Add(lb_Pass);
            pnl_Fondo.Controls.Add(pnl_Lateral);
            pnl_Fondo.Dock = DockStyle.Fill;
            pnl_Fondo.Location = new Point(0, 0);
            pnl_Fondo.Name = "pnl_Fondo";
            pnl_Fondo.Size = new Size(780, 330);
            pnl_Fondo.TabIndex = 0;
            // 
            // picPass
            // 
            picPass.Image = Properties.Resources.Password;
            picPass.Location = new Point(283, 151);
            picPass.Name = "picPass";
            picPass.Size = new Size(20, 20);
            picPass.TabIndex = 9;
            picPass.TabStop = false;
            // 
            // btnSee
            // 
            btnSee.FlatAppearance.BorderSize = 0;
            btnSee.FlatStyle = FlatStyle.Flat;
            btnSee.Image = Properties.Resources.Eye;
            btnSee.Location = new Point(662, 148);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(24, 20);
            btnSee.TabIndex = 8;
            btnSee.UseVisualStyleBackColor = true;
            btnSee.Click += btnSee_Click;
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.User;
            picUser.Location = new Point(283, 96);
            picUser.Name = "picUser";
            picUser.Size = new Size(20, 20);
            picUser.TabIndex = 7;
            picUser.TabStop = false;
            // 
            // lb_Error
            // 
            lb_Error.AutoSize = true;
            lb_Error.Font = new Font("MS Reference Sans Serif", 10.5F);
            lb_Error.ForeColor = Color.DarkGray;
            lb_Error.Image = Properties.Resources.Box_Important;
            lb_Error.ImageAlign = ContentAlignment.MiddleLeft;
            lb_Error.Location = new Point(304, 190);
            lb_Error.Name = "lb_Error";
            lb_Error.Size = new Size(44, 18);
            lb_Error.TabIndex = 6;
            lb_Error.Text = "Error";
            lb_Error.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 19);
            panel1.TabIndex = 2;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // btn_Salir
            // 
            btn_Salir.FlatAppearance.BorderSize = 0;
            btn_Salir.FlatAppearance.MouseDownBackColor = Color.Red;
            btn_Salir.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Image = Properties.Resources.x_;
            btn_Salir.Location = new Point(507, -1);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(23, 20);
            btn_Salir.TabIndex = 7;
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DimGray;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.DimGray;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(434, 295);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(157, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ha olvidado su contraseña?";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(40, 40, 40);
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = Color.Gainsboro;
            btn_Login.Location = new Point(368, 242);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(288, 35);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "ACCEDER";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // lb_Iniciar
            // 
            lb_Iniciar.AutoSize = true;
            lb_Iniciar.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Iniciar.ForeColor = Color.DimGray;
            lb_Iniciar.Location = new Point(417, 32);
            lb_Iniciar.Name = "lb_Iniciar";
            lb_Iniciar.Size = new Size(206, 33);
            lb_Iniciar.TabIndex = 5;
            lb_Iniciar.Text = "INICIAR SESIÓN";
            // 
            // txt_Pass
            // 
            txt_Pass.BackColor = Color.FromArgb(15, 15, 15);
            txt_Pass.BorderStyle = BorderStyle.None;
            txt_Pass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Pass.ForeColor = Color.DimGray;
            txt_Pass.Location = new Point(304, 151);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(352, 20);
            txt_Pass.TabIndex = 2;
            txt_Pass.Text = "Contraseña";
            txt_Pass.Enter += txt_Pass_Enter;
            txt_Pass.Leave += txt_Pass_Leave;
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.FromArgb(15, 15, 15);
            txt_Usuario.BorderStyle = BorderStyle.None;
            txt_Usuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Usuario.ForeColor = Color.DimGray;
            txt_Usuario.Location = new Point(304, 96);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(386, 20);
            txt_Usuario.TabIndex = 1;
            txt_Usuario.Text = "Usuario";
            txt_Usuario.Enter += txt_Usuario_Enter;
            txt_Usuario.Leave += txt_Usuario_Leave;
            // 
            // lb_Usuario
            // 
            lb_Usuario.AutoSize = true;
            lb_Usuario.BackColor = Color.FromArgb(15, 15, 15);
            lb_Usuario.ForeColor = Color.White;
            lb_Usuario.Location = new Point(281, 104);
            lb_Usuario.Name = "lb_Usuario";
            lb_Usuario.Size = new Size(412, 15);
            lb_Usuario.TabIndex = 1;
            lb_Usuario.Text = "_________________________________________________________________________________";
            // 
            // lb_Pass
            // 
            lb_Pass.AutoSize = true;
            lb_Pass.BackColor = Color.Transparent;
            lb_Pass.ForeColor = Color.White;
            lb_Pass.Location = new Point(281, 158);
            lb_Pass.Name = "lb_Pass";
            lb_Pass.Size = new Size(412, 15);
            lb_Pass.TabIndex = 4;
            lb_Pass.Text = "_________________________________________________________________________________";
            // 
            // pnl_Lateral
            // 
            pnl_Lateral.BackColor = Color.FromArgb(0, 122, 204);
            pnl_Lateral.Controls.Add(lb_Name_Clinica);
            pnl_Lateral.Controls.Add(img_Logo_Blanco);
            pnl_Lateral.Dock = DockStyle.Left;
            pnl_Lateral.Location = new Point(0, 0);
            pnl_Lateral.Name = "pnl_Lateral";
            pnl_Lateral.Size = new Size(250, 330);
            pnl_Lateral.TabIndex = 0;
            pnl_Lateral.MouseMove += pnl_Lateral_MouseMove;
            // 
            // lb_Name_Clinica
            // 
            lb_Name_Clinica.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name_Clinica.ForeColor = Color.White;
            lb_Name_Clinica.Location = new Point(36, 203);
            lb_Name_Clinica.Name = "lb_Name_Clinica";
            lb_Name_Clinica.Size = new Size(174, 61);
            lb_Name_Clinica.TabIndex = 1;
            lb_Name_Clinica.Text = "Clinica MedCare";
            lb_Name_Clinica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // img_Logo_Blanco
            // 
            img_Logo_Blanco.Image = Properties.Resources.Logo_Blanco1;
            img_Logo_Blanco.Location = new Point(36, 63);
            img_Logo_Blanco.Name = "img_Logo_Blanco";
            img_Logo_Blanco.Size = new Size(169, 155);
            img_Logo_Blanco.TabIndex = 0;
            img_Logo_Blanco.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 330);
            Controls.Add(pnl_Fondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnl_Fondo.ResumeLayout(false);
            pnl_Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            panel1.ResumeLayout(false);
            pnl_Lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Logo_Blanco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Fondo;
        private Panel pnl_Lateral;
        private Label lb_Usuario;
        private TextBox txt_Usuario;
        private TextBox txt_Pass;
        private Label lb_Pass;
        private Button btn_Login;
        private Label lb_Iniciar;
        private Button btn_Salir;
        private PictureBox img_Logo_Blanco;
        private LinkLabel linkLabel1;
        private Label lb_Name_Clinica;
        private Panel panel1;
        private Label lb_Error;
        private PictureBox picUser;
        private Button btnSee;
        private PictureBox picPass;
    }
}
