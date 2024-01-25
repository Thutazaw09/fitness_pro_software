namespace fitness_pro_software.models
{
    internal class YogaModel : ActivityModel
    {
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
    }
}
