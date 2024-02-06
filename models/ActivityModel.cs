namespace fitness_pro_software.models
{
    internal abstract class ActivityModel
    {
        // getters and setters 
        // Name of the activity
        public abstract string ActivityName { get; set; }

        // Name of the metrics
        public abstract string Metric1Name { get; set; }
        public abstract string Metric2Name { get; set; } 
        public abstract string Metric3Name { get; set; }

        // Value of the Metrics
        public abstract double Metric1Value { get; set; }
        public abstract double Metric2Value { get; set; }
        public abstract double Metric3Value { get; set; }

        public abstract double BurnCalorie();
      
    }
}
