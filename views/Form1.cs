using fitness_pro_software.controllers;
using fitness_pro_software.models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;


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

        private void update_the_display()
        {
            string name = ControllerDatabase.get_user_name_from_db(this.userID);
            int age = ControllerDatabase.get_age_from_db(this.userID);
            int goal = (ControllerDatabase.get_goal_from_db(this.userID));
            int calorie_burned = (ControllerDatabase.get_calorie_burned_from_db(this.userID));

            goal_output_lb.Text = Convert.ToString(goal);
            result_lb.Text = Convert.ToString(calorie_burned);


        }
        private string update_panel(string goal)
        {
            goal_output_lb.Text = goal;
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user_info_panel1.Visible = true;
            user_info_panel1.SetUserID(this.userID);
            activity_panel_big1.SetUserID(this.userID);

            update_the_display();
            user_info_panel1.changes(update_panel);
        }


        private void user_info_panel1_Load(object sender, EventArgs e)
        {
            update_the_display();
        }

        private void activity_panel_big1_Load(object sender, EventArgs e)
        {

            update_the_display();

        }

        // bottons
        private void user_pnl_Click(object sender, EventArgs e)
        {
            user_info_panel1.Visible = true;
            activity_panel_big1.Visible = false;
            update_the_display();
        }
        private void activity_pnl_Click(object sender, EventArgs e)
        {
            user_info_panel1.Visible = false;
            activity_panel_big1.Visible = true;
            update_the_display();
        }

        private void logout_pnl_Click(object sender, EventArgs e)
        {
            frmLogin logout = new frmLogin();
            DialogResult result = MessageBox.Show("You are logging out", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
                logout.Show();
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
