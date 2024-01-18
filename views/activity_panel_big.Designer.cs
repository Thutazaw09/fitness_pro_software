namespace fitness_pro_software
{
    partial class activity_panel_big
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activity_panel_big));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            yoga_btn = new Button();
            button6 = new Button();
            swimming_btn = new Button();
            walking_btn = new Button();
            running_btn = new Button();
            dancing_btn = new Button();
            cycling_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(424, 20);
            label1.Name = "label1";
            label1.Size = new Size(178, 34);
            label1.TabIndex = 0;
            label1.Text = "ACTIVITIES";
            // 
            // button1
            // 
            button1.Location = new Point(107, 106);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(435, 106);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(725, 106);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(725, 343);
            button4.Name = "button4";
            button4.Size = new Size(0, 0);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // yoga_btn
            // 
            yoga_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yoga_btn.Image = (Image)resources.GetObject("yoga_btn.Image");
            yoga_btn.Location = new Point(136, 332);
            yoga_btn.Name = "yoga_btn";
            yoga_btn.Size = new Size(180, 180);
            yoga_btn.TabIndex = 5;
            yoga_btn.Text = "Yoga";
            yoga_btn.UseVisualStyleBackColor = true;
            yoga_btn.Click += yoga_btn_Click;
            // 
            // button6
            // 
            button6.Location = new Point(435, 343);
            button6.Name = "button6";
            button6.Size = new Size(0, 0);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // swimming_btn
            // 
            swimming_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            swimming_btn.Image = (Image)resources.GetObject("swimming_btn.Image");
            swimming_btn.Location = new Point(710, 109);
            swimming_btn.Name = "swimming_btn";
            swimming_btn.Size = new Size(180, 180);
            swimming_btn.TabIndex = 7;
            swimming_btn.Text = "Swimming";
            swimming_btn.UseVisualStyleBackColor = true;
            swimming_btn.Click += button7_Click;
            // 
            // walking_btn
            // 
            walking_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            walking_btn.Image = (Image)resources.GetObject("walking_btn.Image");
            walking_btn.Location = new Point(136, 109);
            walking_btn.Name = "walking_btn";
            walking_btn.Size = new Size(180, 180);
            walking_btn.TabIndex = 8;
            walking_btn.Text = "Walking";
            walking_btn.UseVisualStyleBackColor = true;
            walking_btn.Click += walking_btn_Click;
            // 
            // running_btn
            // 
            running_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            running_btn.Image = (Image)resources.GetObject("running_btn.Image");
            running_btn.Location = new Point(423, 109);
            running_btn.Name = "running_btn";
            running_btn.Size = new Size(180, 180);
            running_btn.TabIndex = 9;
            running_btn.Text = "Running";
            running_btn.UseVisualStyleBackColor = true;
            running_btn.Click += running_btn_Click;
            // 
            // dancing_btn
            // 
            dancing_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dancing_btn.Image = (Image)resources.GetObject("dancing_btn.Image");
            dancing_btn.Location = new Point(423, 332);
            dancing_btn.Name = "dancing_btn";
            dancing_btn.Size = new Size(180, 180);
            dancing_btn.TabIndex = 10;
            dancing_btn.Text = "Dancing";
            dancing_btn.UseVisualStyleBackColor = true;
            dancing_btn.Click += dancing_btn_Click;
            // 
            // cycling_btn
            // 
            cycling_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cycling_btn.Image = (Image)resources.GetObject("cycling_btn.Image");
            cycling_btn.Location = new Point(710, 332);
            cycling_btn.Name = "cycling_btn";
            cycling_btn.Size = new Size(180, 180);
            cycling_btn.TabIndex = 11;
            cycling_btn.Text = "Cycling";
            cycling_btn.UseVisualStyleBackColor = true;
            cycling_btn.Click += cycling_btn_Click;
            // 
            // activity_panel_big
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(cycling_btn);
            Controls.Add(dancing_btn);
            Controls.Add(running_btn);
            Controls.Add(walking_btn);
            Controls.Add(swimming_btn);
            Controls.Add(button6);
            Controls.Add(yoga_btn);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.RosyBrown;
            Name = "activity_panel_big";
            Size = new Size(1026, 579);
            Load += activity_panel_big_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button yoga_btn;
        private Button button6;
        private Button swimming_btn;
        private Button walking_btn;
        private Button running_btn;
        private Button dancing_btn;
        private Button cycling_btn;
    }
}
