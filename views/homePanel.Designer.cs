namespace fitness_pro_software
{
    partial class HomePanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            label1 = new Label();
            LeftPanel = new Panel();
            pictureBox1 = new PictureBox();
            logout_pnl = new Button();
            activity_pnl = new Button();
            user_pnl = new Button();
            Top_Panel = new Panel();
            current_panel_disp = new Label();
            home_icon = new PictureBox();
            activity_icon = new PictureBox();
            activityPanel1 = new activityPanel();
            Home_Panel = new Panel();
            panel3 = new Panel();
            calories_burned_disp = new TextBox();
            progressBar1 = new ProgressBar();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            goal_input_field = new TextBox();
            clear_calories_burned_btn = new Button();
            set_goal_btn = new Button();
            clear_goal_btn = new Button();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            update_info_btn = new Button();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            name_input_field = new TextBox();
            age_input_field = new TextBox();
            weight_input_field = new TextBox();
            height_input_field = new TextBox();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)home_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activity_icon).BeginInit();
            Home_Panel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(578, 39);
            label1.Name = "label1";
            label1.Size = new Size(494, 57);
            label1.TabIndex = 0;
            label1.Text = "FITNESS TRACKER";
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.White;
            LeftPanel.BackgroundImageLayout = ImageLayout.None;
            LeftPanel.BorderStyle = BorderStyle.FixedSingle;
            LeftPanel.Controls.Add(pictureBox1);
            LeftPanel.Controls.Add(logout_pnl);
            LeftPanel.Controls.Add(activity_pnl);
            LeftPanel.Controls.Add(user_pnl);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.ForeColor = Color.FromArgb(116, 86, 174);
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(150, 664);
            LeftPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // logout_pnl
            // 
            logout_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logout_pnl.BackColor = Color.White;
            logout_pnl.FlatStyle = FlatStyle.Popup;
            logout_pnl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_pnl.ForeColor = Color.FromArgb(116, 86, 174);
            logout_pnl.Location = new Point(10, 598);
            logout_pnl.Name = "logout_pnl";
            logout_pnl.Size = new Size(130, 50);
            logout_pnl.TabIndex = 4;
            logout_pnl.Text = "LOGOUT";
            logout_pnl.UseVisualStyleBackColor = false;
            logout_pnl.Click += Logout_pnl_Click;
            // 
            // activity_pnl
            // 
            activity_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            activity_pnl.BackColor = Color.White;
            activity_pnl.FlatStyle = FlatStyle.Popup;
            activity_pnl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activity_pnl.ForeColor = Color.FromArgb(116, 86, 174);
            activity_pnl.Location = new Point(10, 236);
            activity_pnl.Name = "activity_pnl";
            activity_pnl.Size = new Size(130, 50);
            activity_pnl.TabIndex = 3;
            activity_pnl.Text = "ACTIVITIES";
            activity_pnl.UseVisualStyleBackColor = false;
            activity_pnl.Click += Activity_pnl_Click;
            // 
            // user_pnl
            // 
            user_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_pnl.BackColor = Color.White;
            user_pnl.FlatStyle = FlatStyle.Flat;
            user_pnl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_pnl.ForeColor = Color.FromArgb(116, 86, 174);
            user_pnl.Location = new Point(10, 169);
            user_pnl.Name = "user_pnl";
            user_pnl.Size = new Size(130, 50);
            user_pnl.TabIndex = 2;
            user_pnl.Text = "HOME";
            user_pnl.UseVisualStyleBackColor = false;
            user_pnl.Click += User_pnl_Click;
            // 
            // Top_Panel
            // 
            Top_Panel.BorderStyle = BorderStyle.FixedSingle;
            Top_Panel.Controls.Add(current_panel_disp);
            Top_Panel.Controls.Add(home_icon);
            Top_Panel.Controls.Add(activity_icon);
            Top_Panel.Controls.Add(label1);
            Top_Panel.Dock = DockStyle.Top;
            Top_Panel.Location = new Point(150, 0);
            Top_Panel.Name = "Top_Panel";
            Top_Panel.Size = new Size(1108, 135);
            Top_Panel.TabIndex = 3;
            // 
            // current_panel_disp
            // 
            current_panel_disp.AutoSize = true;
            current_panel_disp.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            current_panel_disp.ForeColor = Color.FromArgb(116, 86, 174);
            current_panel_disp.Location = new Point(168, 47);
            current_panel_disp.Name = "current_panel_disp";
            current_panel_disp.Size = new Size(106, 46);
            current_panel_disp.TabIndex = 2;
            current_panel_disp.Text = "panel";
            // 
            // home_icon
            // 
            home_icon.Image = (Image)resources.GetObject("home_icon.Image");
            home_icon.Location = new Point(28, 17);
            home_icon.Name = "home_icon";
            home_icon.Size = new Size(134, 100);
            home_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            home_icon.TabIndex = 4;
            home_icon.TabStop = false;
            // 
            // activity_icon
            // 
            activity_icon.Image = (Image)resources.GetObject("activity_icon.Image");
            activity_icon.InitialImage = (Image)resources.GetObject("activity_icon.InitialImage");
            activity_icon.Location = new Point(28, 17);
            activity_icon.Name = "activity_icon";
            activity_icon.Size = new Size(134, 100);
            activity_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            activity_icon.TabIndex = 5;
            activity_icon.TabStop = false;
            // 
            // activityPanel1
            // 
            activityPanel1.BackColor = Color.White;
            activityPanel1.ForeColor = Color.RosyBrown;
            activityPanel1.Location = new Point(0, 0);
            activityPanel1.Name = "activityPanel1";
            activityPanel1.Size = new Size(1108, 523);
            activityPanel1.TabIndex = 6;
            // 
            // Home_Panel
            // 
            Home_Panel.Controls.Add(activityPanel1);
            Home_Panel.Controls.Add(panel3);
            Home_Panel.Controls.Add(panel4);
            Home_Panel.Dock = DockStyle.Bottom;
            Home_Panel.Location = new Point(150, 141);
            Home_Panel.Name = "Home_Panel";
            Home_Panel.Size = new Size(1108, 523);
            Home_Panel.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(calories_burned_disp);
            panel3.Controls.Add(progressBar1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(goal_input_field);
            panel3.Controls.Add(clear_calories_burned_btn);
            panel3.Controls.Add(set_goal_btn);
            panel3.Controls.Add(clear_goal_btn);
            panel3.ForeColor = Color.FromArgb(116, 86, 174);
            panel3.Location = new Point(629, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 479);
            panel3.TabIndex = 22;
            // 
            // calories_burned_disp
            // 
            calories_burned_disp.Location = new Point(142, 373);
            calories_burned_disp.Name = "calories_burned_disp";
            calories_burned_disp.Size = new Size(112, 31);
            calories_burned_disp.TabIndex = 23;
            calories_burned_disp.TextAlign = HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.Red;
            progressBar1.Location = new Point(57, 82);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(310, 34);
            progressBar1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Times New Roman", 16F);
            label7.ForeColor = Color.FromArgb(116, 86, 174);
            label7.Location = new Point(109, 21);
            label7.Name = "label7";
            label7.Size = new Size(179, 38);
            label7.TabIndex = 22;
            label7.Text = "PROGRESS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Times New Roman", 16F);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(43, 322);
            label6.Name = "label6";
            label6.Size = new Size(310, 38);
            label6.TabIndex = 21;
            label6.Text = "CALORIES BURNED";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Times New Roman", 16F);
            label9.ForeColor = Color.FromArgb(116, 86, 174);
            label9.Location = new Point(146, 136);
            label9.Name = "label9";
            label9.Size = new Size(104, 38);
            label9.TabIndex = 20;
            label9.Text = "GOAL";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 314);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 18;
            label8.Text = "label8";
            // 
            // goal_input_field
            // 
            goal_input_field.Location = new Point(142, 192);
            goal_input_field.Name = "goal_input_field";
            goal_input_field.Size = new Size(112, 31);
            goal_input_field.TabIndex = 12;
            goal_input_field.TextAlign = HorizontalAlignment.Center;
            // 
            // clear_calories_burned_btn
            // 
            clear_calories_burned_btn.BackColor = Color.FromArgb(116, 86, 174);
            clear_calories_burned_btn.ForeColor = Color.White;
            clear_calories_burned_btn.Location = new Point(133, 416);
            clear_calories_burned_btn.Name = "clear_calories_burned_btn";
            clear_calories_burned_btn.Size = new Size(130, 50);
            clear_calories_burned_btn.TabIndex = 13;
            clear_calories_burned_btn.Text = "CLEAR";
            clear_calories_burned_btn.UseVisualStyleBackColor = false;
            clear_calories_burned_btn.Click += Clear_calories_burned_btn_Click_1;
            // 
            // set_goal_btn
            // 
            set_goal_btn.BackColor = Color.FromArgb(116, 86, 174);
            set_goal_btn.ForeColor = Color.White;
            set_goal_btn.Location = new Point(54, 238);
            set_goal_btn.Name = "set_goal_btn";
            set_goal_btn.Size = new Size(130, 50);
            set_goal_btn.TabIndex = 14;
            set_goal_btn.Text = "SET GOAL";
            set_goal_btn.UseVisualStyleBackColor = false;
            set_goal_btn.Click += Set_goal_btn_Click_1;
            // 
            // clear_goal_btn
            // 
            clear_goal_btn.BackColor = Color.FromArgb(116, 86, 174);
            clear_goal_btn.ForeColor = Color.White;
            clear_goal_btn.Location = new Point(212, 238);
            clear_goal_btn.Name = "clear_goal_btn";
            clear_goal_btn.Size = new Size(130, 50);
            clear_goal_btn.TabIndex = 15;
            clear_goal_btn.Text = "CLEAR";
            clear_goal_btn.UseVisualStyleBackColor = false;
            clear_goal_btn.Click += Clear_goal_btn_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(update_info_btn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(name_input_field);
            panel4.Controls.Add(age_input_field);
            panel4.Controls.Add(weight_input_field);
            panel4.Controls.Add(height_input_field);
            panel4.ForeColor = Color.FromArgb(116, 86, 174);
            panel4.Location = new Point(85, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(398, 479);
            panel4.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 16F);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(36, 21);
            label2.Name = "label2";
            label2.Size = new Size(324, 38);
            label2.TabIndex = 19;
            label2.Text = "USER INFORMATION";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(32, 140);
            label3.Name = "label3";
            label3.Size = new Size(112, 27);
            label3.TabIndex = 2;
            label3.Text = "NAME     ";
            // 
            // update_info_btn
            // 
            update_info_btn.BackColor = Color.FromArgb(116, 86, 174);
            update_info_btn.ForeColor = Color.White;
            update_info_btn.Location = new Point(133, 416);
            update_info_btn.Name = "update_info_btn";
            update_info_btn.Size = new Size(130, 50);
            update_info_btn.TabIndex = 18;
            update_info_btn.Text = "UPDATE";
            update_info_btn.UseVisualStyleBackColor = false;
            update_info_btn.Click += Update_info_btn_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(32, 194);
            label4.Name = "label4";
            label4.Size = new Size(115, 27);
            label4.TabIndex = 3;
            label4.Text = "AGE         ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(32, 250);
            label5.Name = "label5";
            label5.Size = new Size(115, 27);
            label5.TabIndex = 4;
            label5.Text = "WIGHT    ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(32, 307);
            label10.Name = "label10";
            label10.Size = new Size(118, 27);
            label10.TabIndex = 5;
            label10.Text = "HEIGHT   ";
            // 
            // name_input_field
            // 
            name_input_field.Location = new Point(150, 139);
            name_input_field.Name = "name_input_field";
            name_input_field.Size = new Size(214, 31);
            name_input_field.TabIndex = 6;
            // 
            // age_input_field
            // 
            age_input_field.Location = new Point(150, 192);
            age_input_field.Name = "age_input_field";
            age_input_field.Size = new Size(214, 31);
            age_input_field.TabIndex = 7;
            // 
            // weight_input_field
            // 
            weight_input_field.Location = new Point(150, 249);
            weight_input_field.Name = "weight_input_field";
            weight_input_field.Size = new Size(214, 31);
            weight_input_field.TabIndex = 8;
            // 
            // height_input_field
            // 
            height_input_field.Location = new Point(150, 306);
            height_input_field.Name = "height_input_field";
            height_input_field.Size = new Size(214, 31);
            height_input_field.TabIndex = 9;
            // 
            // homePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1258, 664);
            Controls.Add(Home_Panel);
            Controls.Add(Top_Panel);
            Controls.Add(LeftPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "homePanel";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            Load += Form1_Load;
            LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Top_Panel.ResumeLayout(false);
            Top_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)home_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)activity_icon).EndInit();
            Home_Panel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel LeftPanel;
        private Button logout_pnl;
        private Button activity_pnl;
        private Button user_pnl;
        
        private Panel Top_Panel;
        private PictureBox home_icon;
        private PictureBox activity_icon;
        private PictureBox pictureBox1;
        private Label current_panel_disp;
        private Panel Home_Panel;
        private activityPanel activityPanel1;
        
        private Panel panel3;
        private ProgressBar progressBar1;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private TextBox goal_input_field;
        private Button clear_calories_burned_btn;
        private Button set_goal_btn;
        private Button clear_goal_btn;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Button update_info_btn;
        private Label label4;
        private Label label5;
        private Label label10;
        private TextBox name_input_field;
        private TextBox age_input_field;
        private TextBox weight_input_field;
        private TextBox height_input_field;
        private TextBox calories_burned_disp;
    }
}
