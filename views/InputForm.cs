using fitness_pro_software.controllers;
using fitness_pro_software.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_pro_software
{
    public partial class InputForm : Form
    {
        WalkingModel walking_model = new WalkingModel();
        DancingModel dancing_model = new DancingModel();
        SwimmingModel swimming_model = new SwimmingModel();
        CyclingModel cycling_model = new CyclingModel();
        YogaModel yoga_model = new YogaModel(); 
        RunningModel running_model = new RunningModel();
        public string activity_name;
        private int userID;
        public void setuserID(int userID)
        {
            this.userID = userID;
        }
        public InputForm(string activity_name)
        {
            this.activity_name = activity_name;
            
            InitializeComponent();


            if (activity_name == (string)walking_model.ActivityName) 
            {
                label1.Text = walking_model.Metric1Name;
                label2.Text = walking_model.Metric2Name;
                label3.Text = walking_model.Metric3Name;
                label4.Text = walking_model.ActivityName;
            }
            else if(activity_name == (string)dancing_model.ActivityName)
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


        private void button1_Click(object sender, EventArgs e)
        {
            // coming from input

            try
            {
                double metric1_value = Convert.ToDouble(textBox1.Text);
                double metric2_value = Convert.ToDouble(textBox2.Text);
                double metric3_value = Convert.ToDouble(textBox3.Text);
                double result = 0.0;
                

                if (this.activity_name == (string)walking_model.ActivityName)
                {
                    result = ControllerModel.WalkingBurn(metric1_value, metric2_value, metric3_value);
                }
                else if (this.activity_name == (string)running_model.ActivityName)
                {
                    result = ControllerModel.RunningBurn(metric1_value, metric2_value, metric3_value);
                }
                else if (this.activity_name == (string)swimming_model.ActivityName)
                {
                    result = ControllerModel.SwimmingBurn(metric1_value, metric2_value, metric3_value);
                }
                else if (this.activity_name == (string)dancing_model.ActivityName)
                {
                    result = ControllerModel.DancingBurn(metric1_value, metric2_value, metric3_value);
                }
                else if (this.activity_name == (string)yoga_model.ActivityName)
                {
                    result = ControllerModel.YogaBurn(metric1_value, metric2_value, metric3_value);
                }
                else if (this.activity_name == (string)cycling_model.ActivityName)
                {
                    result = ControllerModel.CyclingBurn(metric1_value, metric2_value, metric3_value);
                }
                else
                {
                    result = 0.0;
                }

                int previous_result = ControllerDatabase.get_calorie_burned_from_db(this.userID);
                int updated_result = previous_result + Convert.ToInt32(result);
                int goal = ControllerDatabase.get_goal_from_db(this.userID);

                if (updated_result >= goal ) {
                    ControllerDatabase.update_calorie_burned_in_db(this.userID, 0);
                    MessageBox.Show("You hit the goal\nYour progress have been resest");
                }
                else
                {
                    ControllerDatabase.update_calorie_burned_in_db(this.userID, updated_result);
                }
               

                MessageBox.Show($"You are doing {this.activity_name} and burn {result} calories"); // result will go to database
                CloseForm1();
                
                Form1 main = new Form1(userID);
                main.Show();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                
            }
            
        }
        private void CloseForm1()
        {
            // Iterate through open forms and close the BackgroundForm
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Close();
                    break; // Exit the loop once you find and close the BackgroundForm
                }
            }
        }
            private void InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
