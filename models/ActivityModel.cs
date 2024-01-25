namespace fitness_pro_software.models
{
    internal abstract class ActivityModel
    {
        // getters and setters 
        // Name of the activity
        public string ActivityName { get; set; } = "";

        // Name of the metrics
        public string Metric1Name { get; set; } = "";
        public string Metric2Name { get; set; } = "";
        public string Metric3Name { get; set; } = "";

        // Value of the Metrics
        public double Metric1Value { get; set; }
        public double Metric2Value { get; set; }
        public double Metric3Value { get; set; }

    }
}
