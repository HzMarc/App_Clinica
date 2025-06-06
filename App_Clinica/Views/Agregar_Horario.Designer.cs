namespace App_Clinica.Views
{
    partial class Agregar_Horario
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
            btnNew = new Button();
            btnGuardar = new Button();
            pnlDomingo = new Panel();
            label14 = new Label();
            cmbDomingoHasta = new ComboBox();
            cmbDomingoDesde = new ComboBox();
            label15 = new Label();
            chkDomingo = new CheckBox();
            pnlSabado = new Panel();
            label12 = new Label();
            cmbSabadoHasta = new ComboBox();
            cmbSabadoDesde = new ComboBox();
            label13 = new Label();
            chkSabado = new CheckBox();
            pnlViernes = new Panel();
            label10 = new Label();
            cmbViernesHasta = new ComboBox();
            cmbViernesDesde = new ComboBox();
            label11 = new Label();
            chkViernes = new CheckBox();
            pnlJueves = new Panel();
            label8 = new Label();
            cmbJuevesHasta = new ComboBox();
            cmbJuevesDesde = new ComboBox();
            label9 = new Label();
            chkJueves = new CheckBox();
            pnlMiercoles = new Panel();
            label6 = new Label();
            cmbMiercolesHasta = new ComboBox();
            cmbMiercolesDesde = new ComboBox();
            label7 = new Label();
            chkMiercoles = new CheckBox();
            pnlMartes = new Panel();
            label4 = new Label();
            cmbMartesHasta = new ComboBox();
            cmbMartesDesde = new ComboBox();
            label5 = new Label();
            chkMartes = new CheckBox();
            pmlLunes = new Panel();
            label3 = new Label();
            cmbLunesHasta = new ComboBox();
            cmbLunesDesde = new ComboBox();
            label2 = new Label();
            chkLunes = new CheckBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnltool = new Panel();
            btnSalir = new Button();
            panel1.SuspendLayout();
            pnlDomingo.SuspendLayout();
            pnlSabado.SuspendLayout();
            pnlViernes.SuspendLayout();
            pnlJueves.SuspendLayout();
            pnlMiercoles.SuspendLayout();
            pnlMartes.SuspendLayout();
            pmlLunes.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnltool.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(pnlDomingo);
            panel1.Controls.Add(pnlSabado);
            panel1.Controls.Add(pnlViernes);
            panel1.Controls.Add(pnlJueves);
            panel1.Controls.Add(pnlMiercoles);
            panel1.Controls.Add(pnlMartes);
            panel1.Controls.Add(pmlLunes);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnltool);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 710);
            panel1.TabIndex = 0;
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
            btnNew.Location = new Point(25, 653);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(175, 33);
            btnNew.TabIndex = 102;
            btnNew.Text = "    Nuevo";
            btnNew.UseVisualStyleBackColor = false;
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
            btnGuardar.Location = new Point(383, 650);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(175, 33);
            btnGuardar.TabIndex = 101;
            btnGuardar.Text = "     Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlDomingo
            // 
            pnlDomingo.BackColor = Color.FromArgb(232, 232, 232);
            pnlDomingo.Controls.Add(label14);
            pnlDomingo.Controls.Add(cmbDomingoHasta);
            pnlDomingo.Controls.Add(cmbDomingoDesde);
            pnlDomingo.Controls.Add(label15);
            pnlDomingo.Controls.Add(chkDomingo);
            pnlDomingo.Location = new Point(25, 592);
            pnlDomingo.Name = "pnlDomingo";
            pnlDomingo.Size = new Size(533, 52);
            pnlDomingo.TabIndex = 100;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label14.Location = new Point(346, 20);
            label14.Name = "label14";
            label14.Size = new Size(47, 17);
            label14.TabIndex = 92;
            label14.Text = "Hasta:";
            // 
            // cmbDomingoHasta
            // 
            cmbDomingoHasta.FormattingEnabled = true;
            cmbDomingoHasta.Location = new Point(402, 17);
            cmbDomingoHasta.Name = "cmbDomingoHasta";
            cmbDomingoHasta.Size = new Size(121, 23);
            cmbDomingoHasta.TabIndex = 91;
            // 
            // cmbDomingoDesde
            // 
            cmbDomingoDesde.FormattingEnabled = true;
            cmbDomingoDesde.Location = new Point(200, 16);
            cmbDomingoDesde.Name = "cmbDomingoDesde";
            cmbDomingoDesde.Size = new Size(121, 23);
            cmbDomingoDesde.TabIndex = 90;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(144, 18);
            label15.Name = "label15";
            label15.Size = new Size(50, 17);
            label15.TabIndex = 89;
            label15.Text = "Desde:";
            // 
            // chkDomingo
            // 
            chkDomingo.AutoSize = true;
            chkDomingo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            chkDomingo.Location = new Point(35, 13);
            chkDomingo.Name = "chkDomingo";
            chkDomingo.Size = new Size(93, 24);
            chkDomingo.TabIndex = 94;
            chkDomingo.Text = "Domingo";
            chkDomingo.UseVisualStyleBackColor = true;
            // 
            // pnlSabado
            // 
            pnlSabado.BackColor = Color.FromArgb(232, 232, 232);
            pnlSabado.Controls.Add(label12);
            pnlSabado.Controls.Add(cmbSabadoHasta);
            pnlSabado.Controls.Add(cmbSabadoDesde);
            pnlSabado.Controls.Add(label13);
            pnlSabado.Controls.Add(chkSabado);
            pnlSabado.Location = new Point(25, 523);
            pnlSabado.Name = "pnlSabado";
            pnlSabado.Size = new Size(533, 52);
            pnlSabado.TabIndex = 99;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(346, 20);
            label12.Name = "label12";
            label12.Size = new Size(47, 17);
            label12.TabIndex = 92;
            label12.Text = "Hasta:";
            // 
            // cmbSabadoHasta
            // 
            cmbSabadoHasta.FormattingEnabled = true;
            cmbSabadoHasta.Location = new Point(402, 17);
            cmbSabadoHasta.Name = "cmbSabadoHasta";
            cmbSabadoHasta.Size = new Size(121, 23);
            cmbSabadoHasta.TabIndex = 91;
            // 
            // cmbSabadoDesde
            // 
            cmbSabadoDesde.FormattingEnabled = true;
            cmbSabadoDesde.Location = new Point(200, 16);
            cmbSabadoDesde.Name = "cmbSabadoDesde";
            cmbSabadoDesde.Size = new Size(121, 23);
            cmbSabadoDesde.TabIndex = 90;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(144, 18);
            label13.Name = "label13";
            label13.Size = new Size(50, 17);
            label13.TabIndex = 89;
            label13.Text = "Desde:";
            // 
            // chkSabado
            // 
            chkSabado.AutoSize = true;
            chkSabado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            chkSabado.Location = new Point(36, 16);
            chkSabado.Name = "chkSabado";
            chkSabado.Size = new Size(79, 24);
            chkSabado.TabIndex = 93;
            chkSabado.Text = "Sábado";
            chkSabado.UseVisualStyleBackColor = true;
            // 
            // pnlViernes
            // 
            pnlViernes.BackColor = Color.FromArgb(232, 232, 232);
            pnlViernes.Controls.Add(label10);
            pnlViernes.Controls.Add(cmbViernesHasta);
            pnlViernes.Controls.Add(cmbViernesDesde);
            pnlViernes.Controls.Add(label11);
            pnlViernes.Controls.Add(chkViernes);
            pnlViernes.Location = new Point(25, 448);
            pnlViernes.Name = "pnlViernes";
            pnlViernes.Size = new Size(533, 52);
            pnlViernes.TabIndex = 98;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(346, 20);
            label10.Name = "label10";
            label10.Size = new Size(47, 17);
            label10.TabIndex = 92;
            label10.Text = "Hasta:";
            // 
            // cmbViernesHasta
            // 
            cmbViernesHasta.FormattingEnabled = true;
            cmbViernesHasta.Location = new Point(402, 17);
            cmbViernesHasta.Name = "cmbViernesHasta";
            cmbViernesHasta.Size = new Size(121, 23);
            cmbViernesHasta.TabIndex = 91;
            // 
            // cmbViernesDesde
            // 
            cmbViernesDesde.FormattingEnabled = true;
            cmbViernesDesde.Location = new Point(200, 16);
            cmbViernesDesde.Name = "cmbViernesDesde";
            cmbViernesDesde.Size = new Size(121, 23);
            cmbViernesDesde.TabIndex = 90;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(144, 18);
            label11.Name = "label11";
            label11.Size = new Size(50, 17);
            label11.TabIndex = 89;
            label11.Text = "Desde:";
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            chkViernes.Location = new Point(35, 13);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(80, 24);
            chkViernes.TabIndex = 92;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // pnlJueves
            // 
            pnlJueves.BackColor = Color.FromArgb(232, 232, 232);
            pnlJueves.Controls.Add(label8);
            pnlJueves.Controls.Add(cmbJuevesHasta);
            pnlJueves.Controls.Add(cmbJuevesDesde);
            pnlJueves.Controls.Add(label9);
            pnlJueves.Controls.Add(chkJueves);
            pnlJueves.Location = new Point(25, 377);
            pnlJueves.Name = "pnlJueves";
            pnlJueves.Size = new Size(533, 52);
            pnlJueves.TabIndex = 97;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(346, 20);
            label8.Name = "label8";
            label8.Size = new Size(47, 17);
            label8.TabIndex = 92;
            label8.Text = "Hasta:";
            // 
            // cmbJuevesHasta
            // 
            cmbJuevesHasta.FormattingEnabled = true;
            cmbJuevesHasta.Location = new Point(402, 17);
            cmbJuevesHasta.Name = "cmbJuevesHasta";
            cmbJuevesHasta.Size = new Size(121, 23);
            cmbJuevesHasta.TabIndex = 91;
            // 
            // cmbJuevesDesde
            // 
            cmbJuevesDesde.FormattingEnabled = true;
            cmbJuevesDesde.Location = new Point(200, 16);
            cmbJuevesDesde.Name = "cmbJuevesDesde";
            cmbJuevesDesde.Size = new Size(121, 23);
            cmbJuevesDesde.TabIndex = 90;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(144, 18);
            label9.Name = "label9";
            label9.Size = new Size(50, 17);
            label9.TabIndex = 89;
            label9.Text = "Desde:";
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            chkJueves.Location = new Point(38, 13);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(75, 24);
            chkJueves.TabIndex = 91;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // pnlMiercoles
            // 
            pnlMiercoles.BackColor = Color.FromArgb(232, 232, 232);
            pnlMiercoles.Controls.Add(label6);
            pnlMiercoles.Controls.Add(cmbMiercolesHasta);
            pnlMiercoles.Controls.Add(cmbMiercolesDesde);
            pnlMiercoles.Controls.Add(label7);
            pnlMiercoles.Controls.Add(chkMiercoles);
            pnlMiercoles.Location = new Point(25, 310);
            pnlMiercoles.Name = "pnlMiercoles";
            pnlMiercoles.Size = new Size(533, 52);
            pnlMiercoles.TabIndex = 96;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(346, 20);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 92;
            label6.Text = "Hasta:";
            // 
            // cmbMiercolesHasta
            // 
            cmbMiercolesHasta.FormattingEnabled = true;
            cmbMiercolesHasta.Location = new Point(402, 17);
            cmbMiercolesHasta.Name = "cmbMiercolesHasta";
            cmbMiercolesHasta.Size = new Size(121, 23);
            cmbMiercolesHasta.TabIndex = 91;
            // 
            // cmbMiercolesDesde
            // 
            cmbMiercolesDesde.FormattingEnabled = true;
            cmbMiercolesDesde.Location = new Point(200, 16);
            cmbMiercolesDesde.Name = "cmbMiercolesDesde";
            cmbMiercolesDesde.Size = new Size(121, 23);
            cmbMiercolesDesde.TabIndex = 90;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(144, 18);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 89;
            label7.Text = "Desde:";
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMiercoles.Location = new Point(38, 14);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(95, 24);
            chkMiercoles.TabIndex = 90;
            chkMiercoles.Text = "Miércoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // pnlMartes
            // 
            pnlMartes.BackColor = Color.FromArgb(232, 232, 232);
            pnlMartes.Controls.Add(label4);
            pnlMartes.Controls.Add(cmbMartesHasta);
            pnlMartes.Controls.Add(cmbMartesDesde);
            pnlMartes.Controls.Add(label5);
            pnlMartes.Controls.Add(chkMartes);
            pnlMartes.Location = new Point(25, 242);
            pnlMartes.Name = "pnlMartes";
            pnlMartes.Size = new Size(533, 52);
            pnlMartes.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(346, 20);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 92;
            label4.Text = "Hasta:";
            // 
            // cmbMartesHasta
            // 
            cmbMartesHasta.FormattingEnabled = true;
            cmbMartesHasta.Location = new Point(402, 17);
            cmbMartesHasta.Name = "cmbMartesHasta";
            cmbMartesHasta.Size = new Size(121, 23);
            cmbMartesHasta.TabIndex = 91;
            // 
            // cmbMartesDesde
            // 
            cmbMartesDesde.FormattingEnabled = true;
            cmbMartesDesde.Location = new Point(200, 16);
            cmbMartesDesde.Name = "cmbMartesDesde";
            cmbMartesDesde.Size = new Size(121, 23);
            cmbMartesDesde.TabIndex = 90;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(144, 18);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 89;
            label5.Text = "Desde:";
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMartes.Location = new Point(38, 14);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(77, 24);
            chkMartes.TabIndex = 89;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // pmlLunes
            // 
            pmlLunes.BackColor = Color.FromArgb(232, 232, 232);
            pmlLunes.Controls.Add(label3);
            pmlLunes.Controls.Add(cmbLunesHasta);
            pmlLunes.Controls.Add(cmbLunesDesde);
            pmlLunes.Controls.Add(label2);
            pmlLunes.Controls.Add(chkLunes);
            pmlLunes.Location = new Point(25, 173);
            pmlLunes.Name = "pmlLunes";
            pmlLunes.Size = new Size(533, 52);
            pmlLunes.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(346, 20);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 92;
            label3.Text = "Hasta:";
            // 
            // cmbLunesHasta
            // 
            cmbLunesHasta.FormattingEnabled = true;
            cmbLunesHasta.Location = new Point(402, 17);
            cmbLunesHasta.Name = "cmbLunesHasta";
            cmbLunesHasta.Size = new Size(121, 23);
            cmbLunesHasta.TabIndex = 91;
            // 
            // cmbLunesDesde
            // 
            cmbLunesDesde.FormattingEnabled = true;
            cmbLunesDesde.Location = new Point(200, 16);
            cmbLunesDesde.Name = "cmbLunesDesde";
            cmbLunesDesde.Size = new Size(121, 23);
            cmbLunesDesde.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 18);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 89;
            label2.Text = "Desde:";
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkLunes.Location = new Point(38, 16);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(69, 24);
            chkLunes.TabIndex = 88;
            chkLunes.Text = "Lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 242, 253);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 124);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(233, 233, 233);
            panel3.Location = new Point(616, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(694, 559);
            panel3.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 118, 210);
            label1.Location = new Point(259, 89);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 1;
            label1.Text = "Agregar Horario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Schedule;
            pictureBox1.Location = new Point(285, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnltool
            // 
            pnltool.BackColor = Color.FromArgb(227, 242, 253);
            pnltool.Controls.Add(btnSalir);
            pnltool.Dock = DockStyle.Top;
            pnltool.Location = new Point(0, 0);
            pnltool.Name = "pnltool";
            pnltool.Size = new Size(588, 29);
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
            btnSalir.Location = new Point(557, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(31, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Agregar_Horario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 710);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_Horario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Horario";
            panel1.ResumeLayout(false);
            pnlDomingo.ResumeLayout(false);
            pnlDomingo.PerformLayout();
            pnlSabado.ResumeLayout(false);
            pnlSabado.PerformLayout();
            pnlViernes.ResumeLayout(false);
            pnlViernes.PerformLayout();
            pnlJueves.ResumeLayout(false);
            pnlJueves.PerformLayout();
            pnlMiercoles.ResumeLayout(false);
            pnlMiercoles.PerformLayout();
            pnlMartes.ResumeLayout(false);
            pnlMartes.PerformLayout();
            pmlLunes.ResumeLayout(false);
            pmlLunes.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnltool.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnltool;
        private Button btnSalir;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pmlLunes;
        private CheckBox chkDomingo;
        private CheckBox chkSabado;
        private CheckBox chkViernes;
        private CheckBox chkJueves;
        private CheckBox chkMiercoles;
        private CheckBox chkMartes;
        private Label label2;
        private CheckBox chkLunes;
        private Label label3;
        private ComboBox cmbLunesHasta;
        private ComboBox cmbLunesDesde;
        private Panel pnlMartes;
        private Label label4;
        private ComboBox cmbMartesHasta;
        private ComboBox cmbMartesDesde;
        private Label label5;
        private Panel pnlMiercoles;
        private Label label6;
        private ComboBox cmbMiercolesHasta;
        private ComboBox cmbMiercolesDesde;
        private Label label7;
        private Panel pnlDomingo;
        private Label label14;
        private ComboBox cmbDomingoHasta;
        private ComboBox cmbDomingoDesde;
        private Label label15;
        private Panel pnlSabado;
        private Label label12;
        private ComboBox cmbSabadoHasta;
        private ComboBox cmbSabadoDesde;
        private Label label13;
        private Panel pnlViernes;
        private Label label10;
        private ComboBox cmbViernesHasta;
        private ComboBox cmbViernesDesde;
        private Label label11;
        private Panel pnlJueves;
        private Label label8;
        private ComboBox cmbJuevesHasta;
        private ComboBox cmbJuevesDesde;
        private Label label9;
        private Button btnNew;
        private Button btnGuardar;
        private Panel panel3;
    }
}