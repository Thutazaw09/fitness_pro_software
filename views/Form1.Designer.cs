namespace fitness_pro_software
{
    partial class Form1
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
            label1 = new Label();
            panel1 = new Panel();
            name_display = new Label();
            panel4 = new Panel();
            label3 = new Label();
            result_lb = new Label();
            panel3 = new Panel();
            goal_output_lb = new Label();
            label2 = new Label();
            logout_pnl = new Button();
            activity_pnl = new Button();
            user_pnl = new Button();
            panel2 = new Panel();
            user_info_panel1 = new user_info_panel();
            activity_panel_big1 = new activity_panel_big();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(591, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 45);
            label1.TabIndex = 0;
            label1.Text = "FITNESS PRO";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(name_display);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(logout_pnl);
            panel1.Controls.Add(activity_pnl);
            panel1.Controls.Add(user_pnl);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 663);
            panel1.TabIndex = 1;
            // 
            // name_display
            // 
            name_display.AutoSize = true;
            name_display.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_display.Location = new Point(58, 55);
            name_display.Name = "name_display";
            name_display.Size = new Size(83, 33);
            name_display.TabIndex = 3;
            name_display.Text = "label4";
            name_display.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(result_lb);
            panel4.Location = new Point(17, 425);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 95);
            panel4.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 22);
            label3.Name = "label3";
            label3.Size = new Size(88, 54);
            label3.TabIndex = 6;
            label3.Text = "Calorie \r\nBurned";
            // 
            // result_lb
            // 
            result_lb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            result_lb.AutoSize = true;
            result_lb.Font = new Font("Segoe UI", 10F);
            result_lb.Location = new Point(83, 35);
            result_lb.Name = "result_lb";
            result_lb.RightToLeft = RightToLeft.No;
            result_lb.Size = new Size(60, 28);
            result_lb.TabIndex = 8;
            result_lb.Text = "result";
            result_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(goal_output_lb);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(17, 306);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 95);
            panel3.TabIndex = 2;
            // 
            // goal_output_lb
            // 
            goal_output_lb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            goal_output_lb.AutoSize = true;
            goal_output_lb.Font = new Font("Segoe UI", 10F);
            goal_output_lb.Location = new Point(83, 33);
            goal_output_lb.Name = "goal_output_lb";
            goal_output_lb.Size = new Size(51, 28);
            goal_output_lb.TabIndex = 7;
            goal_output_lb.Text = "goal";
            goal_output_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 35);
            label2.Name = "label2";
            label2.Size = new Size(58, 27);
            label2.TabIndex = 5;
            label2.Text = "Goal";
            // 
            // logout_pnl
            // 
            logout_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logout_pnl.BackColor = SystemColors.GradientInactiveCaption;
            logout_pnl.FlatStyle = FlatStyle.Popup;
            logout_pnl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_pnl.Location = new Point(44, 576);
            logout_pnl.Name = "logout_pnl";
            logout_pnl.Size = new Size(120, 30);
            logout_pnl.TabIndex = 4;
            logout_pnl.Text = "LOGOUT";
            logout_pnl.UseVisualStyleBackColor = false;
            logout_pnl.Click += logout_pnl_Click;
            // 
            // activity_pnl
            // 
            activity_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            activity_pnl.BackColor = SystemColors.GradientInactiveCaption;
            activity_pnl.FlatStyle = FlatStyle.Popup;
            activity_pnl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activity_pnl.Location = new Point(24, 228);
            activity_pnl.Name = "activity_pnl";
            activity_pnl.Size = new Size(158, 53);
            activity_pnl.TabIndex = 3;
            activity_pnl.Text = "ACTIVITIES";
            activity_pnl.UseVisualStyleBackColor = false;
            activity_pnl.Click += activity_pnl_Click;
            // 
            // user_pnl
            // 
            user_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_pnl.BackColor = SystemColors.GradientInactiveCaption;
            user_pnl.FlatStyle = FlatStyle.Popup;
            user_pnl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_pnl.Location = new Point(24, 158);
            user_pnl.Name = "user_pnl";
            user_pnl.Size = new Size(158, 53);
            user_pnl.TabIndex = 2;
            user_pnl.Text = "USER";
            user_pnl.UseVisualStyleBackColor = false;
            user_pnl.Click += user_pnl_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(user_info_panel1);
            panel2.Controls.Add(activity_panel_big1);
            panel2.Location = new Point(224, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 578);
            panel2.TabIndex = 2;
            // 
            // user_info_panel1
            // 
            user_info_panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_info_panel1.BackColor = SystemColors.ActiveCaption;
            user_info_panel1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_info_panel1.Location = new Point(0, 3);
            user_info_panel1.Name = "user_info_panel1";
            user_info_panel1.Size = new Size(1026, 576);
            user_info_panel1.TabIndex = 1;
            user_info_panel1.Load += user_info_panel1_Load;
            // 
            // activity_panel_big1
            // 
            activity_panel_big1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            activity_panel_big1.BackColor = SystemColors.ActiveCaption;
            activity_panel_big1.ForeColor = Color.RosyBrown;
            activity_panel_big1.Location = new Point(0, -1);
            activity_panel_big1.Name = "activity_panel_big1";
            activity_panel_big1.Size = new Size(1026, 579);
            activity_panel_big1.TabIndex = 0;
            activity_panel_big1.Load += activity_panel_big1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "DashBoard";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button logout_pnl;
        private Button activity_pnl;
        private Button user_pnl;
        private Panel panel2;
        private activity_panel_big activity_panel_big1;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private Label goal_output_lb;
        private Label result_lb;
        private user_info_panel user_info_panel1;
        private Label name_display;
    }
}
