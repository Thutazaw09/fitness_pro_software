using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_pro_software.models
{
    internal class DancingModel : ActivityModel
    {
        public DancingModel() 
        {
            // defining the name of activity
            this.ActivityName = "Dancing";

            // defining the name of metrics
            this.Metric1Name = "Number of Moves";
            this.Metric2Name = "Duration(h)";
            this.Metric3Name = "Intensity Level";

            // metrics values will be defined through controllers
        }
    }
}
