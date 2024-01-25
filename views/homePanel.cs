using fitness_pro_software.controllers;

namespace fitness_pro_software
{
    public partial class HomePanel : Form
    {
        public int UserID { get; set; }

        public HomePanel(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            activityPanel1.SetUserID(this.UserID);
        }
        private void PanelSelector(bool activity_panel)
        {
            if (activity_panel)
            {
                activityPanel1.Visible = true;
                current_panel_disp.Text = "ACTIVITIES";

            }
            else
            {
                activityPanel1.Visible = false;
                current_panel_disp.Text = "HOME";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PanelSelector(false);
            DataUpdater();

        }
        private void DataUpdater()
        {
            name_input_field.Text = ControllerDatabase.GetUserNameFromDb(this.UserID);
            age_input_field.Text = Convert.ToString(ControllerDatabase.GetAgeFromDb(this.UserID));
            height_input_field.Text = Convert.ToString(ControllerDatabase.GetHeightFromDb(this.UserID) * 1000);
            weight_input_field.Text = Convert.ToString(ControllerDatabase.GetWeightFromDb(this.UserID));

            int goal = ControllerDatabase.GetGoalFromDb(this.UserID);
            int calorie_burned = ControllerDatabase.GetCalorieBurnedFromDb(this.UserID);

            goal_input_field.Text = Convert.ToString(goal);
            calories_burned_disp.Text = Convert.ToString(calorie_burned);

            progressBar1.Maximum = goal;
            progressBar1.Value = calorie_burned;
        }

        // buttons section
        private void Logout_pnl_Click(object sender, EventArgs e)
        {
            FrmLogin logout = new();
            DialogResult result = MessageBox.Show("You are logging out", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
                logout.Show();
            }

        }

        private void User_pnl_Click(object sender, EventArgs e)
        {
            PanelSelector(false);
            DataUpdater();
        }

        private void Activity_pnl_Click(object sender, EventArgs e)
        {
            PanelSelector(true);
            DataUpdater();
        }

        private void Update_info_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string new_name = name_input_field.Text;
                int new_age = Convert.ToInt32(age_input_field.Text);
                double new_weight = Convert.ToDouble(weight_input_field.Text);
                double new_height = Convert.ToDouble(height_input_field.Text) / 1000;

                ControllerDatabase.UpdateUserNameInDb(this.UserID, new_name);
                ControllerDatabase.UpdateAgeInDb(this.UserID, new_age);
                ControllerDatabase.UpdateHeightInDb(this.UserID, new_height);
                ControllerDatabase.UpdateWeightInDb(this.UserID, new_weight);

                MessageBox.Show("Update Success", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdater();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_goal_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                ControllerDatabase.UpdateGoalInDb(this.UserID, Convert.ToInt32(goal_input_field.Text));
                MessageBox.Show("Set Goal Success", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdater();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_goal_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                ControllerDatabase.UpdateGoalInDb(this.UserID, 0);
                MessageBox.Show("Clear Goal Success", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdater();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Clear_calories_burned_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                ControllerDatabase.UpdateCalorieBurnedInDb(this.UserID, 0);
                MessageBox.Show("Clear Calories Burned Success", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdater();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
