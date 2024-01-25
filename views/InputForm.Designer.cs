namespace fitness_pro_software
{
    partial class InputForm
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.ForeColor = Color.White;
            button1.Location = new Point(132, 232);
            button1.Name = "button1";
            button1.Size = new Size(131, 48);
            button1.TabIndex = 13;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(70, 27);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(70, 27);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(70, 27);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 20F);
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(141, 15);
            label4.Name = "label4";
            label4.Size = new Size(112, 40);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(395, 292);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputForm";
            Load += InputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}