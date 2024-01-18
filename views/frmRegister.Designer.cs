namespace fitness_pro_software
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user_name_txt = new TextBox();
            password_txt = new TextBox();
            label4 = new Label();
            confirm_password_txt = new TextBox();
            label5 = new Label();
            show_password_checkbox = new CheckBox();
            register_btn = new Button();
            exit_btn = new Button();
            to_login = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Size = new Size(225, 40);
            label1.TabIndex = 0;
            label1.Text = "GET START";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 151);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 461);
            label3.Name = "label3";
            label3.Size = new Size(158, 19);
            label3.TabIndex = 2;
            label3.Text = "Already have an account";
            // 
            // user_name_txt
            // 
            user_name_txt.Location = new Point(34, 174);
            user_name_txt.Name = "user_name_txt";
            user_name_txt.Size = new Size(216, 28);
            user_name_txt.TabIndex = 3;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(34, 243);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(216, 28);
            password_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 220);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(105, 20);
            label4.TabIndex = 4;
            label4.Text = "PASSWORD";
            // 
            // confirm_password_txt
            // 
            confirm_password_txt.Location = new Point(34, 312);
            confirm_password_txt.Name = "confirm_password_txt";
            confirm_password_txt.Size = new Size(216, 28);
            confirm_password_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 289);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(192, 20);
            label5.TabIndex = 6;
            label5.Text = "CONFIRM PASSWORD";
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(116, 346);
            show_password_checkbox.Name = "show_password_checkbox";
            show_password_checkbox.Size = new Size(129, 23);
            show_password_checkbox.TabIndex = 8;
            show_password_checkbox.Text = "Show Password";
            show_password_checkbox.UseVisualStyleBackColor = true;
            show_password_checkbox.CheckedChanged += show_password_checkbox_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(116, 86, 174);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(34, 382);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(216, 35);
            register_btn.TabIndex = 9;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.White;
            exit_btn.ForeColor = Color.FromArgb(116, 86, 174);
            exit_btn.Location = new Point(34, 423);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(216, 35);
            exit_btn.TabIndex = 10;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // to_login
            // 
            to_login.AutoSize = true;
            to_login.BackColor = Color.Transparent;
            to_login.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            to_login.ForeColor = Color.FromArgb(116, 86, 174);
            to_login.Location = new Point(100, 480);
            to_login.Name = "to_login";
            to_login.Size = new Size(61, 19);
            to_login.TabIndex = 11;
            to_login.Text = "LOGIN";
            to_login.Click += to_login_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(to_login);
            Controls.Add(exit_btn);
            Controls.Add(register_btn);
            Controls.Add(show_password_checkbox);
            Controls.Add(confirm_password_txt);
            Controls.Add(label5);
            Controls.Add(password_txt);
            Controls.Add(label4);
            Controls.Add(user_name_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox user_name_txt;
        private TextBox password_txt;
        private Label label4;
        private TextBox confirm_password_txt;
        private Label label5;
        private CheckBox show_password_checkbox;
        private Button register_btn;
        private Button exit_btn;
        private Label to_login;
    }
}