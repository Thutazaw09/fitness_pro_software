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
    public partial class user_info_panel : UserControl
    {
        public user_info_panel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            update_info_btn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(360, 35);
            label1.Name = "label1";
            label1.Size = new Size(307, 34);
            label1.TabIndex = 1;
            label1.Text = "USER INFORMATION";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(30, 44);
            label2.Name = "label2";
            label2.Size = new Size(112, 27);
            label2.TabIndex = 2;
            label2.Text = "NAME     ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(30, 98);
            label3.Name = "label3";
            label3.Size = new Size(115, 27);
            label3.TabIndex = 3;
            label3.Text = "AGE         ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(30, 154);
            label4.Name = "label4";
            label4.Size = new Size(115, 27);
            label4.TabIndex = 4;
            label4.Text = "WIGHT    ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(30, 211);
            label5.Name = "label5";
            label5.Size = new Size(118, 27);
            label5.TabIndex = 5;
            label5.Text = "HEIGHT   ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 30);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 30);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 30);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 30);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(78, 260);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(146, 73);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 30);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(170, 42);
            label6.Name = "label6";
            label6.Size = new Size(107, 27);
            label6.TabIndex = 11;
            label6.Text = "GOAL     ";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(146, 254);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(92, 112);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 14;
            button3.Text = "SET GOAL";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(210, 113);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 15;
            button4.Text = "CLEAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(146, 215);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(112, 30);
            textBox6.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(87, 183);
            label7.Name = "label7";
            label7.Size = new Size(255, 27);
            label7.TabIndex = 16;
            label7.Text = "CALORIES BURNED    ";
            // 
            // update_info_btn
            // 
            update_info_btn.BackColor = SystemColors.ActiveCaption;
            update_info_btn.ForeColor = SystemColors.ActiveCaptionText;
            update_info_btn.Location = new Point(207, 260);
            update_info_btn.Name = "update_info_btn";
            update_info_btn.Size = new Size(112, 34);
            update_info_btn.TabIndex = 18;
            update_info_btn.Text = "UPDATE";
            update_info_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(update_info_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(button1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(76, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 327);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.ForeColor = Color.Chocolate;
            panel2.Location = new Point(545, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 327);
            panel2.TabIndex = 19;
            // 
            // user_info_panel
            // 
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "user_info_panel";
            Size = new Size(1026, 579);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private Button update_info_btn;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
    }
}
