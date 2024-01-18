using System.Threading;

namespace fitness_pro_software
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (!show_password_checkbox.Checked)
            {
                password_txt.UseSystemPasswordChar = true;
            }
            else
            {
                password_txt.UseSystemPasswordChar = false;
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void to_register_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            Visible = false;
        }
        private void show_password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!show_password_checkbox.Checked)
            {
                password_txt.UseSystemPasswordChar = true;
            }
            else
            {
                password_txt.UseSystemPasswordChar = false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = user_name_txt.Text;
            string password = password_txt.Text;

            if (LoginUser.AuthenticateUser(username, password))
            {
                // Redirect to the main fitness tracking interface
                MessageBox.Show("Login successful!");
                Form1 login = new Form1();
                login.Show();
                Visible=false;
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
