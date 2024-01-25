namespace fitness_pro_software
{
    partial class activityPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activityPanel));
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
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(107, 106);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(476, 58);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(725, 106);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(733, 343);
            button4.Name = "button4";
            button4.Size = new Size(0, 0);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // yoga_btn
            // 
            yoga_btn.Cursor = Cursors.Hand;
            yoga_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yoga_btn.Image = (Image)resources.GetObject("yoga_btn.Image");
            yoga_btn.Location = new Point(144, 284);
            yoga_btn.Name = "yoga_btn";
            yoga_btn.Size = new Size(180, 180);
            yoga_btn.TabIndex = 5;
            yoga_btn.UseVisualStyleBackColor = true;
            yoga_btn.Click += Yoga_btn_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(484, 295);
            button6.Name = "button6";
            button6.Size = new Size(0, 0);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // swimming_btn
            // 
            swimming_btn.Cursor = Cursors.Hand;
            swimming_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            swimming_btn.Image = (Image)resources.GetObject("swimming_btn.Image");
            swimming_btn.Location = new Point(784, 61);
            swimming_btn.Name = "swimming_btn";
            swimming_btn.Size = new Size(180, 180);
            swimming_btn.TabIndex = 7;
            swimming_btn.UseVisualStyleBackColor = true;
            swimming_btn.Click += Button7_Click;
            // 
            // walking_btn
            // 
            walking_btn.Cursor = Cursors.Hand;
            walking_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            walking_btn.Image = (Image)resources.GetObject("walking_btn.Image");
            walking_btn.Location = new Point(144, 61);
            walking_btn.Name = "walking_btn";
            walking_btn.Size = new Size(180, 180);
            walking_btn.TabIndex = 8;
            walking_btn.UseVisualStyleBackColor = true;
            walking_btn.Click += Walking_btn_Click;
            // 
            // running_btn
            // 
            running_btn.Cursor = Cursors.Hand;
            running_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            running_btn.Image = (Image)resources.GetObject("running_btn.Image");
            running_btn.Location = new Point(464, 61);
            running_btn.Name = "running_btn";
            running_btn.Size = new Size(180, 180);
            running_btn.TabIndex = 9;
            running_btn.UseVisualStyleBackColor = true;
            running_btn.Click += Running_btn_Click;
            // 
            // dancing_btn
            // 
            dancing_btn.Cursor = Cursors.Hand;
            dancing_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dancing_btn.Image = (Image)resources.GetObject("dancing_btn.Image");
            dancing_btn.Location = new Point(464, 284);
            dancing_btn.Name = "dancing_btn";
            dancing_btn.Size = new Size(180, 180);
            dancing_btn.TabIndex = 10;
            dancing_btn.UseVisualStyleBackColor = true;
            dancing_btn.Click += Dancing_btn_Click;
            // 
            // cycling_btn
            // 
            cycling_btn.Cursor = Cursors.Hand;
            cycling_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cycling_btn.Image = (Image)resources.GetObject("cycling_btn.Image");
            cycling_btn.Location = new Point(784, 295);
            cycling_btn.Name = "cycling_btn";
            cycling_btn.Size = new Size(180, 180);
            cycling_btn.TabIndex = 11;
            cycling_btn.UseVisualStyleBackColor = true;
            cycling_btn.Click += Cycling_btn_Click;
            // 
            // activityPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
            ForeColor = Color.RosyBrown;
            Name = "activityPanel";
            Size = new Size(1108, 523);
            Load += Activity_panel_big_Load;
            ResumeLayout(false);
        }

        #endregion
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
