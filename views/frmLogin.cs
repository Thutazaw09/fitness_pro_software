using System.Threading;

namespace fitness_pro_software
{
    public partial class frmLogin : Form
    {
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 5;
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
            Application.Exit();
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
                loginAttempts = 0;
                // Redirect to the main fitness tracking interface
                int userID = LoginUser.GetUserID(username, password);
                if (userID != -1)
                {
                    MessageBox.Show("Login successful!");
                    Form1 login = new Form1(userID);
                    login.Show();
                    this.Hide();
                }
            }
            else
            {
                loginAttempts++;
                if (loginAttempts >= maxLoginAttempts)
                {
                    MessageBox.Show($"Too many unsuccessful login attempts. App Will be closing .");
                    Application.Exit(); 
                }
                else
                {
                    MessageBox.Show($"Invalid username or password. Attempts left: {maxLoginAttempts - loginAttempts}");
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
