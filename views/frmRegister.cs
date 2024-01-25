using fitness_pro_software.controllers;

namespace fitness_pro_software
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            if (show_password_checkbox.Checked)
            {
                password_txt.UseSystemPasswordChar = false;
                confirm_password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
                confirm_password_txt.UseSystemPasswordChar = true;
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void To_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new();
            login.Show();
        }

        private void Show_password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_checkbox.Checked)
            {
                password_txt.UseSystemPasswordChar = false;
                confirm_password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
                confirm_password_txt.UseSystemPasswordChar = true;
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string username = user_name_txt.Text;
            string password = password_txt.Text;

            LoginUser.RegisterUser(username, password);

            MessageBox.Show("User registered successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            user_name_txt.Clear();
            password_txt.Clear();
            confirm_password_txt.Clear();

        }
    }
}
