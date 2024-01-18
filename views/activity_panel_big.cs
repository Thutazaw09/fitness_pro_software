using fitness_pro_software.controllers;
using fitness_pro_software.models;
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
    public partial class activity_panel_big : UserControl
    {
      
        public activity_panel_big()
        {
            InitializeComponent();
        }

        private void activity_panel_big_Load(object sender, EventArgs e)
        {
    
          
 
        }

        private void walking_btn_Click(object sender, EventArgs e)
        {
            WalkingModel walking = new WalkingModel();

            InputForm inputform = new InputForm(walking.ActivityName);
            inputform.Show();

            
        }

        private void running_btn_Click(object sender, EventArgs e)
        {
            RunningModel running = new RunningModel();
            InputForm inputform = new InputForm(running.ActivityName);
            inputform.Show();
        }

        private void yoga_btn_Click(object sender, EventArgs e)
        {
            YogaModel yoga = new YogaModel();
            InputForm inputform = new InputForm(yoga.ActivityName);
            inputform.Show();
        }

        private void dancing_btn_Click(object sender, EventArgs e)
        {
            DancingModel dancing = new DancingModel();
            InputForm inputform = new InputForm(dancing.ActivityName);
            inputform.Show();
        }

        private void cycling_btn_Click(object sender, EventArgs e)
        {
            CyclingModel cycling = new CyclingModel();
            InputForm inputform = new InputForm(cycling.ActivityName);
            inputform.Show();
        }


       
        private void button7_Click(object sender, EventArgs e)
        {
            SwimmingModel swimming = new SwimmingModel();
            InputForm inputform = new InputForm(swimming.ActivityName);
            inputform.Show();
        }
    }
}
