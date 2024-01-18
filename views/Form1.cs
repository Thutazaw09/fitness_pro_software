using fitness_pro_software.models;

namespace fitness_pro_software
{
    public partial class Form1 : Form
    {
        public string goal_of_user = "1000";
        public string result_of_user = "10000";
        public Form1()
        {
            InitializeComponent();

        }


        // dashboard section //
        private void Form1_Load(object sender, EventArgs e)
        {
            user_info_panel1.Visible = true;
            activity_panel_big1.Visible = false;
            goal_output_lb.Text = this.goal_of_user;
            result_lb.Text=this.result_of_user;

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
