using fitness_pro_software.controllers;
using Microsoft.VisualBasic.ApplicationServices;

namespace fitness_pro_software.models
{
    internal class SwimmingModel : ActivityModel
    {
        private int userID { get; set; }
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
            double no_of_laps = Metric1Value;
            double time_taken = Metric2Value;
            double pool_length = Metric3Value;
            double swimming_efficiency = 0.936;
            double weight = ControllerDatabase.GetWeightFromDb(this.UserID); // unit in kg 
            double swimming_met = 11;
            double result = Math.Round((no_of_laps * pool_length * swimming_efficiency * weight * swimming_met * time_taken), 2);
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
