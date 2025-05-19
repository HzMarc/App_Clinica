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
            if (txt_Pass.Text == "Contrase�a")
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
                txt_Pass.Text = "Contrase�a";
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
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            if (txt_Usuario.Text != "Usuario")
            {
                if (txt_Pass.Text != "Contrase�a")
                {
                    // if ()
                    // {
                    //}
                    //else
                    //{
                    //msgError("Incorrect username or password entered. \n Please try again.");

                    //}

                }
                else msgError("Por favor, introduzca la contrase�a.");
            }
            else msgError("Por favor, introduzca su nombre de usuario.");
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
                txt_Pass.PasswordChar = '�';
                btnSee.Image = Image.FromFile("Resources\\Eye.png");
            }
        }
    }
}
