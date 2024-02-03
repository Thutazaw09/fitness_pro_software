namespace fitness_pro_software
{
    partial class FrmLogin
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
            components = new System.ComponentModel.Container();
            to_register = new Label();
            exit_btn = new Button();
            login_btn = new Button();
            show_password_checkbox = new CheckBox();
            password_txt = new TextBox();
            label4 = new Label();
            user_name_txt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            countdown = new Label();
            SuspendLayout();
            // 
            // to_register
            // 
            to_register.AutoSize = true;
            to_register.BackColor = Color.Transparent;
            to_register.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            to_register.ForeColor = Color.FromArgb(116, 86, 174);
            to_register.Location = new Point(121, 387);
            to_register.Name = "to_register";
            to_register.Size = new Size(90, 19);
            to_register.TabIndex = 23;
            to_register.Text = "REGISTER";
            to_register.Click += To_register_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.White;
            exit_btn.ForeColor = Color.FromArgb(116, 86, 174);
            exit_btn.Location = new Point(55, 324);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(216, 35);
            exit_btn.TabIndex = 22;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += Exit_btn_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(116, 86, 174);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(55, 283);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(216, 35);
            login_btn.TabIndex = 21;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += Login_btn_Click;
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(142, 250);
            show_password_checkbox.Name = "show_password_checkbox";
            show_password_checkbox.Size = new Size(129, 23);
            show_password_checkbox.TabIndex = 20;
            show_password_checkbox.Text = "Show Password";
            show_password_checkbox.UseVisualStyleBackColor = true;
            show_password_checkbox.CheckedChanged += Show_password_checkbox_CheckedChanged;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(55, 214);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(216, 30);
            password_txt.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 191);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(114, 22);
            label4.TabIndex = 16;
            label4.Text = "PASSWORD";
            // 
            // user_name_txt
            // 
            user_name_txt.Location = new Point(55, 145);
            user_name_txt.Name = "user_name_txt";
            user_name_txt.Size = new Size(216, 30);
            user_name_txt.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 366);
            label3.Name = "label3";
            label3.Size = new Size(152, 19);
            label3.TabIndex = 14;
            label3.Text = "Do not have an account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 122);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(116, 22);
            label2.TabIndex = 13;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(94, 58);
            label1.Name = "label1";
            label1.Size = new Size(130, 40);
            label1.TabIndex = 12;
            label1.Text = "LOGIN";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // countdown
            // 
            countdown.AutoSize = true;
            countdown.Location = new Point(111, 23);
            countdown.Name = "countdown";
            countdown.Size = new Size(96, 22);
            countdown.TabIndex = 24;
            countdown.Text = "countdown";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(318, 430);
            Controls.Add(countdown);
            Controls.Add(to_register);
            Controls.Add(exit_btn);
            Controls.Add(login_btn);
            Controls.Add(show_password_checkbox);
            Controls.Add(password_txt);
            Controls.Add(label4);
            Controls.Add(user_name_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label to_register;
        private Button exit_btn;
        private Button login_btn;
        private CheckBox show_password_checkbox;
        private TextBox password_txt;
        private Label label4;
        private TextBox user_name_txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label countdown;
    }
}