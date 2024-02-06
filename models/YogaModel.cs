using fitness_pro_software.controllers;
using Microsoft.VisualBasic.ApplicationServices;

namespace fitness_pro_software.models
{
    internal class YogaModel : ActivityModel
    {
        private int userID { get; set; }
        public YogaModel()
        {
            // defining the name of activity
            this.ActivityName = "Yoga";

            // defining the name of metrics
            this.Metric1Name = "Session Duration(h)";
            this.Metric2Name = "Number of Poses";
            this.Metric3Name = "Time Taken(h)";

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
            double session_duration = Metric1Value;
            double no_of_poses = Metric2Value;
            double time_taken = Metric3Value;
            double yoga_met = 3.3;
            double weight = ControllerDatabase.GetWeightFromDb(this.UserID); // unit in kg ;
            double result = Math.Round((session_duration * weight * yoga_met * time_taken), 2);

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
