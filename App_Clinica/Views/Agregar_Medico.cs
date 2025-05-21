namespace App_Clinica.Views
{
    public partial class Agregar_Medico : Form
    {
        public Agregar_Medico()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
