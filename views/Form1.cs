using fitness_pro_software.controllers;
using fitness_pro_software.models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fitness_pro_software
{
    public partial class Form1 : Form
    {
        private int userID;
        public Form1(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        // dashboard section //
        private void Form1_Load(object sender, EventArgs e)
        {
            user_info_panel1.Visible = true;
            user_info_panel1.SetUserID(this.userID);
            activity_panel_big1.Visible = false;

            // this is testing 
            //string output = ControllerDatabase.get_user_name_from_db(id);
            //int age = ControllerDatabase.get_age_from_db(id);
            //int goal = (ControllerDatabase.get_goal_from_db(id));
            //int result = (ControllerDatabase.get_calorie_burned_from_db(id));
            //double weight = (ControllerDatabase.get_weight_from_db(id));

            //MessageBox.Show($"Name is {id}\nAge is {age}\nGoal is {goal}\result is {result}\nweight is {weight}\n");

            

            //goal_output_lb.Text = Convert.ToString(goal);
            //result_lb.Text= Convert.ToString(result);

        }


        private void user_info_panel1_Load(object sender, EventArgs e)
        {

        }

        private void activity_panel_big1_Load(object sender, EventArgs e)
        {
      

            
        }

        // bottons
        private void user_pnl_Click(object sender, EventArgs e)
        {
            user_info_panel1.Visible = true;
            activity_panel_big1.Visible = false;
        }
        private void activity_pnl_Click(object sender, EventArgs e)
        {
            user_info_panel1.Visible = false;
            activity_panel_big1.Visible = true;
        }

        private void logout_pnl_Click(object sender, EventArgs e)
        {
            frmLogin logout = new frmLogin();
            DialogResult result = MessageBox.Show("You are logging out","Confirmation",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
                logout.Show();
            }
            
        }
    }
}
