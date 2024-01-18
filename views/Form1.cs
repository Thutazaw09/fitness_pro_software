using fitness_pro_software.controllers;
using fitness_pro_software.models;
using System.Windows.Forms;

namespace fitness_pro_software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // dashboard section //
        private void Form1_Load(object sender, EventArgs e)
        {
            user_info_panel1.Visible = true;
            activity_panel_big1.Visible = false;

            // this is testing 
            string output = ControllerDatabase.get_user_name_from_db(1);
            int age = ControllerDatabase.get_age_from_db(1);
            int goal = (ControllerDatabase.get_goal_from_db(1));
            int result = (ControllerDatabase.get_calorie_burned_from_db(1));
            double weight = (ControllerDatabase.get_weight_from_db(1));

            MessageBox.Show($"Name is {output}\nAge is {age}\nGoal is {goal}\result is {result}\nweight is {weight}\n");

            

            goal_output_lb.Text = Convert.ToString(goal);
            result_lb.Text= Convert.ToString(result);





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
            MessageBox.Show("You are logging out");
            logout.Show();
            Visible = false;
            
           
        }
    }
}
