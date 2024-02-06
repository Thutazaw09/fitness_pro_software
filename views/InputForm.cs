using fitness_pro_software.controllers;
using fitness_pro_software.models;

namespace fitness_pro_software
{
    public partial class InputForm : Form
    {
        WalkingModel walking_model = new();
        DancingModel dancing_model = new();
        SwimmingModel swimming_model = new();
        CyclingModel cycling_model = new();
        YogaModel yoga_model = new();
        RunningModel running_model = new();

        public string activity_name;
        private int userID;
        public void SetuserID(int userID)
        {
            this.userID = userID;
         
        }
        private void UpdateDisplay()
        {
            if (activity_name == (string)walking_model.ActivityName)
            {
                label1.Text = walking_model.Metric1Name;
                label2.Text = walking_model.Metric2Name;
                label3.Text = walking_model.Metric3Name;
                label4.Text = walking_model.ActivityName;
            }
            else if (activity_name == (string)dancing_model.ActivityName)
            {
                label1.Text = dancing_model.Metric1Name;
                label2.Text = dancing_model.Metric2Name;
                label3.Text = dancing_model.Metric3Name;
                label4.Text = dancing_model.ActivityName;
            }
            else if (activity_name == (string)swimming_model.ActivityName)
            {
                label1.Text = swimming_model.Metric1Name;
                label2.Text = swimming_model.Metric2Name;
                label3.Text = swimming_model.Metric3Name;
                label4.Text = swimming_model.ActivityName;
            }

            else if (activity_name == (string)yoga_model.ActivityName)
            {
                label1.Text = yoga_model.Metric1Name;
                label2.Text = yoga_model.Metric2Name;
                label3.Text = yoga_model.Metric3Name;
                label4.Text = yoga_model.ActivityName;
            }

            else if (activity_name == (string)cycling_model.ActivityName)
            {
                label1.Text = cycling_model.Metric1Name;
                label2.Text = cycling_model.Metric2Name;
                label3.Text = cycling_model.Metric3Name;
                label4.Text = cycling_model.ActivityName;
            }
            else if (activity_name == (string)running_model.ActivityName)
            {
                label1.Text = running_model.Metric1Name;
                label2.Text = running_model.Metric2Name;
                label3.Text = running_model.Metric3Name;
                label4.Text = running_model.ActivityName;
            }
            else
            {
                label1.Text = "Invalid";
                label2.Text = "Invalid";
                label3.Text = "Invalid";
                label4.Text = "Invalid";
            }
        }

        public InputForm(string activity_name)
        {
            this.activity_name = activity_name;

            InitializeComponent();
            UpdateDisplay();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                double metric1_value = Convert.ToDouble(textBox1.Text);
                double metric2_value = Convert.ToDouble(textBox2.Text);
                double metric3_value = Convert.ToDouble(textBox3.Text);
                double result = 0.0;


                if (this.activity_name == (string)walking_model.ActivityName)
                {
                    walking_model.UserID = userID;
                    walking_model.Metric1Value = metric1_value;
                    walking_model.Metric2Value = metric2_value;
                    walking_model.Metric3Value = metric3_value;
                    result = walking_model.BurnCalorie();
                }
                else if (this.activity_name == (string)running_model.ActivityName)
                {
                    running_model.UserID = userID;
                    running_model.Metric1Value = metric1_value;
                    running_model.Metric2Value = metric2_value;
                    running_model.Metric3Value = metric3_value;
                    result = running_model.BurnCalorie();
                }
                else if (this.activity_name == (string)swimming_model.ActivityName)
                {
                    swimming_model.UserID = userID;
                    swimming_model.Metric1Value = metric1_value;
                    swimming_model.Metric2Value = metric2_value;
                    swimming_model.Metric3Value = metric3_value;
                    result = swimming_model.BurnCalorie();
                }
                else if (this.activity_name == (string)dancing_model.ActivityName)
                {
                    dancing_model.UserID = userID;
                    dancing_model.Metric1Value = metric1_value;
                    dancing_model.Metric2Value = metric2_value;
                    dancing_model.Metric3Value = metric3_value;
                    result = dancing_model.BurnCalorie();
                }
                else if (this.activity_name == (string)yoga_model.ActivityName)
                {
                    yoga_model.UserID = userID;
                    yoga_model.Metric1Value = metric1_value;
                    yoga_model.Metric2Value = metric2_value;
                    yoga_model.Metric3Value = metric3_value;
                    result = yoga_model.BurnCalorie();
                }
                else if (this.activity_name == (string)cycling_model.ActivityName)
                {
                    cycling_model.UserID = userID;
                    cycling_model.Metric1Value = metric1_value;
                    cycling_model.Metric2Value = metric2_value;
                    cycling_model.Metric3Value = metric3_value;
                    result = cycling_model.BurnCalorie();
                }
                else
                {
                    result = 0.0;
                }

                int previous_result = ControllerDatabase.GetCalorieBurnedFromDb(this.userID);
                int updated_result = previous_result + Convert.ToInt32(result);
                int goal = ControllerDatabase.GetGoalFromDb(this.userID);

                if (updated_result >= goal)
                {
                    ControllerDatabase.UpdateCalorieBurnedInDb(this.userID, 0);
                    MessageBox.Show("You hit the goal\nYour progress have been resest", "CONGRATULATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ControllerDatabase.UpdateCalorieBurnedInDb(this.userID, updated_result);
                }


                MessageBox.Show($"You are doing {this.activity_name} and burn {result} calories", "CONGRATULATION", MessageBoxButtons.OK, MessageBoxIcon.Information); // result will go to database




                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
