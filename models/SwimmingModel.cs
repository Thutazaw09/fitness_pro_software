using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_pro_software.models
{
    internal class SwimmingModel : ActivityModel
    {
        public SwimmingModel()
        {
            // defining the name of activity
            this.ActivityName = "Swimming";

            // defining the name of metrics
            this.Metric1Name = "Number of Laps";
            this.Metric2Name = "Time Taken(h)";
            this.Metric3Name = "Pool Length(km)";

            // metrics values will be defined through controllers

        }
    }
}
