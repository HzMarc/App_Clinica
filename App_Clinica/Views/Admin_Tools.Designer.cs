namespace App_Clinica.Views
{
    partial class Admin_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Tools));
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 452);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 45);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 0;
            label1.Text = "Elementos modificables";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(117, 12);
            label7.Name = "label7";
            label7.Size = new Size(313, 41);
            label7.TabIndex = 1;
            label7.Text = "Bienvenido (Admin)";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Location = new Point(305, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 68);
            panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Usuario", "Médico", "Cita", "Servicio", "Pago", "Horario" });
            comboBox1.Location = new Point(31, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 28);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(0, 122, 204);
            button1.Location = new Point(68, 297);
            button1.Name = "button1";
            button1.Size = new Size(129, 80);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // Admin_Tools
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 459);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_Tools";
            Text = "Admin_Tools";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private Panel panel2;
        private Button button1;
        private ComboBox comboBox1;
    }
}