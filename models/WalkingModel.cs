using fitness_pro_software.controllers;

namespace fitness_pro_software.models
{
    internal class WalkingModel : ActivityModel
    {
        private int userID { get; set; }
        public WalkingModel()
        {
            // defining the name of activity
            this.ActivityName = "Walking";

            // defining the name of metrics
            this.Metric1Name = "Steps";
            this.Metric2Name = "Distance(km)";
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
            double no_of_steps = Metric1Value;
            double distance = Metric2Value;
            double time_taken = Metric3Value; // in second
            double step_length = 0.5; // unit in meters
            double weight = ControllerDatabase.GetWeightFromDb(this.UserID); // unit in kg 
            double result = Math.Round((step_length * no_of_steps * weight * 0.035) + (distance * weight * 0.035) + (time_taken * weight * 0.035), 2);
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
