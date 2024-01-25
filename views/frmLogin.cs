namespace fitness_pro_software
{
    public partial class FrmLogin : Form
    {
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 5;
        private DateTime lockoutEndTime;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            countdown.Visible = false;
            if (!show_password_checkbox.Checked)
            {
                password_txt.UseSystemPasswordChar = true;
            }
            else
            {
                password_txt.UseSystemPasswordChar = false;
            }
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void To_register_Click(object sender, EventArgs e)
        {
            frmRegister register = new();
            register.Show();
            Visible = false;
        }
        private void Show_password_checkbox_CheckedChanged(object sender, EventArgs e)
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

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (DateTime.Now < lockoutEndTime)
            {
                MessageBox.Show($"Login attempts exceeded. Please wait for the lockout period to end.", "LOGIN FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Login successful!", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePanel login = new(userID);
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
                    MessageBox.Show($"Too many unsuccessful login attempts. Your account is locked for 1 minute..", "lOGIN FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginAttempts = 2;
                    timer1.Start();

                    countdown.Text = timer1.ToString();
                    countdown.Visible = true;


                }
                else
                {
                    MessageBox.Show($"Invalid username or password. Attempts left: {maxLoginAttempts - loginAttempts}", "lOGIN FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    countdown.Visible = false;
                }

            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= lockoutEndTime)
            {
                timer1.Stop();
                MessageBox.Show("Lockout period ended. You can attempt to login again.", "ALART", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TimeSpan remainingTime = lockoutEndTime - DateTime.Now;
                countdown.Text = $"Lockout: {remainingTime:mm\\:ss}";
            }
        }
    }
}
