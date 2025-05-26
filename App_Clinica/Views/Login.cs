using App_Clinica.DataAccess;
using App_Clinica.Views;

namespace App_Clinica
{
    public partial class Login : Form
    {
        int posx = 0;
        int posy = 0;
        private bool _mostrarContrasena = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "Usuario")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "Usuario";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "Contraseña")
            {
                txt_Pass.Text = "";
                txt_Pass.ForeColor = Color.LightGray;
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "Contraseña";
                txt_Pass.ForeColor = Color.DimGray;
                txt_Pass.UseSystemPasswordChar = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void pnl_Lateral_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "Usuario" || string.IsNullOrWhiteSpace(txt_Usuario.Text))
            {
                msgError("Por favor, introduzca su nombre de usuario.");
                return;
            }
            if (txt_Pass.Text == "Contraseña" || string.IsNullOrWhiteSpace(txt_Pass.Text))
            {
                msgError("Por favor, introduzca la contraseña.");
                return;
            }
            string rol = AutenticacionService.IniciarSesion(txt_Usuario.Text, txt_Pass.Text);
            string usuarioIngresado = txt_Usuario.Text;

            if (rol != null)
            {
                Menu menu = new Menu();
                menu.SetNombreUsuario(usuarioIngresado);
                menu.Show();
                this.Hide();
            }
            else
            {
                msgError("Nombre de usuario o contraseña incorrectos. \nPor favor, inténtelo de nuevo.");
            }
        }
        private void msgError(string msg)
        {
            lb_Error.Text = "   " + msg;
            lb_Error.Visible = true;
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            _mostrarContrasena = !_mostrarContrasena;

            if (_mostrarContrasena)
            {
                txt_Pass.PasswordChar = '\0';
                btnSee.Image = Image.FromFile("Resources\\Blind.png");
            }
            else
            {
                txt_Pass.PasswordChar = '•';
                btnSee.Image = Image.FromFile("Resources\\Eye.png");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
