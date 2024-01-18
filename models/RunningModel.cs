using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_pro_software.models
{
    internal class RunningModel : ActivityModel
    {
        public RunningModel()
        {
            // defining the name of activity
            this.ActivityName = "Running";

            // defining the name of metrics
            this.Metric1Name = "Distance(km)";
            this.Metric2Name = "Time Taken(h)";
            this.Metric3Name = "Average Pace(km/h)";

            // metrics values will be defined through controllers
        }
    }
}
