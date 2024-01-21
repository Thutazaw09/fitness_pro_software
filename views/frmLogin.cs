using System.Threading;

namespace fitness_pro_software
{
    public partial class frmLogin : Form
    {
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 5;
        private DateTime lockoutEndTime;
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
            if (DateTime.Now < lockoutEndTime)
            {
                MessageBox.Show($"Login attempts exceeded. Please wait for the lockout period to end.");
                return;
            }
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
                    lockoutEndTime = DateTime.Now.AddMinutes(1);
                    MessageBox.Show($"Too many unsuccessful login attempts. Your account is locked for 1 minute..");
                    loginAttempts = 2;
                    timer1.Start();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= lockoutEndTime)
            {
                timer1.Stop();
                MessageBox.Show("Lockout period ended. You can attempt to login again.");
            }
            else
            {
                TimeSpan remainingTime = lockoutEndTime - DateTime.Now;
                countdown.Text = $"Lockout: {remainingTime:mm\\:ss}";
            }
        }
    }
}
