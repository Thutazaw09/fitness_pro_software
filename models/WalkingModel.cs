namespace fitness_pro_software.models
{
    internal class WalkingModel : ActivityModel
    {
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

    }

}
