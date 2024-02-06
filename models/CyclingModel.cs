using fitness_pro_software.controllers;
using Microsoft.VisualBasic.ApplicationServices;

namespace fitness_pro_software.models
{
    internal class CyclingModel : ActivityModel
    {
        private int userID { get; set; }
        public CyclingModel()
        {
            // defining the name of activity
            this.ActivityName = "Cycling";

            // defining the name of metrics
            this.Metric1Name = "Distance(km)";
            this.Metric2Name = "Time Taken(h)";
            this.Metric3Name = "Average Speed(km/h)";

            // metrics values will be defined through controllers
        }

        public override double Metric1Value { get; set; }
        public override double Metric2Value { get; set; }
        public override double Metric3Value { get; set; }

        public override string Metric1Name { get; set; }
        public override string Metric2Name { get; set; }
        public override string Metric3Name { get; set; }
        public int UserID { get => userID; set => userID = value; }
        public override string ActivityName { get; set; }

        public override double BurnCalorie()
        {
            double distance = Metric1Value;
            double time_taken = Metric2Value;
            double average_speed = Metric3Value;
            double weight = ControllerDatabase.GetWeightFromDb(this.UserID); // unit in kg ;
            double cycling_met = 7;

            double result = Math.Round((distance * weight * cycling_met * time_taken), 2);

            return result;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
