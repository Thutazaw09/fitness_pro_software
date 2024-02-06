using fitness_pro_software.controllers;
using Microsoft.VisualBasic.ApplicationServices;

namespace fitness_pro_software.models
{
    internal class DancingModel : ActivityModel
    {
        private int userID { get; set; }
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
            double no_of_dance_moves = Metric1Value;
            double time_taken = Metric2Value;
            double intensity_level = Metric3Value;
            double weight = ControllerDatabase.GetWeightFromDb(this.UserID); // unit in kg ;
            double dancing_met = 5;

            double result = Math.Round((no_of_dance_moves * time_taken * weight * dancing_met), 2);

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
