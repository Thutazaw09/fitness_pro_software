namespace fitness_pro_software.models
{
    internal class CyclingModel : ActivityModel
    {
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
    }
}
