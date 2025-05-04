namespace App_Clinica
{
    public partial class Login : Form
    {
        int posx = 0;
        int posy = 0;
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
            if (txt_Usuario.Text != "Usuario")
            {
                if (txt_Pass.Text != "Contraseña")
                {
                   // if ()
                   // {
                    //}
                    //else
                    //{
                        //msgError("Incorrect username or password entered. \n Please try again.");
                        
                    //}

                }
                else msgError("Por favor, introduzca la contraseña.");
            }
            else msgError("Por favor, introduzca su nombre de usuario.");
        }
        private void msgError(string msg)
        {
            lb_Error.Text = "   " + msg;
            lb_Error.Visible = true;
        }
    }
}
