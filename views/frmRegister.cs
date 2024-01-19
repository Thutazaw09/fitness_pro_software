using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_pro_software
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void to_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void show_password_checkbox_CheckedChanged(object sender, EventArgs e)
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

        private void register_btn_Click(object sender, EventArgs e)
        {
            string username = user_name_txt.Text;
            string password = password_txt.Text;

            LoginUser.RegisterUser(username, password);

            MessageBox.Show("User registered successfully.");

            user_name_txt.Clear();
            password_txt.Clear();
            confirm_password_txt.Clear();

        }
    }
}
