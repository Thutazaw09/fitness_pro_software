namespace fitness_pro_software.controllers
{
    static class ControllerModel

    {
        // this willl come from database
        public static double user_weight = 55;
        public static double user_height = .175; // m


        // all the calculations are done with metric system nad kcal
        public static double WalkingBurn(double metric_1_value, double metric_2_value, double metric_3_value)
        {
            double no_of_steps = metric_1_value;
            double distance = metric_2_value;
            double time_taken = metric_3_value; // in second
            double step_length = 0.5; // unit in meters
            double weight = user_weight; // unit in kg 
            double result = Math.Round((step_length * no_of_steps * weight * 0.035) + (distance * weight * 0.035) + (time_taken * weight * 0.035), 2);
            return result;
        }
        public static double SwimmingBurn(double metric_1_value, double metric_2_value, double metric_3_value)
        {
            double no_of_laps = metric_1_value;
            double time_taken = metric_2_value;
            double pool_length = metric_3_value;
            double swimming_efficiency = 0.936;
            double weight = user_weight;
            double swimming_met = 11;
            double result = Math.Round((no_of_laps * pool_length * swimming_efficiency * weight * swimming_met * time_taken), 2);
            return result;
        }
        public static double RunningBurn(double metric_1_value, double metric_2_value, double metric_3_value)
        {
            double distance = metric_1_value;
            double time_taken = metric_2_value;
            double average_pace = metric_3_value;
            double running_met = 5.5;
            double weight = user_weight;

            double result = Math.Round((distance * weight * running_met * time_taken), 2);
            return result;
        }
        public static double DancingBurn(double metric_1_value, double metric_2_value, double metric_3_value)
        {
            double no_of_dance_moves = metric_1_value;
            double time_taken = metric_2_value;
            double intensity_level = metric_3_value;
            double weight = user_weight;
            double dancing_met = 5;

            double result = Math.Round((no_of_dance_moves * time_taken * weight * dancing_met), 2);

            return result;
        }
        public static double YogaBurn(double metric_1_value, double metric_2_value, double metric_3_value)
        {
            double session_duration = metric_1_value;
            double no_of_poses = metric_2_value;
            double time_taken = metric_3_value;
            double yoga_met = 3.3;
            double weight = user_weight;
            double result = Math.Round((session_duration * weight * yoga_met * time_taken), 2);

            return result;
        }
        public static double CyclingBurn(double metric_1_value, double metric_2_value, double metric_3_value)
        {
            double distance = metric_1_value;
            double time_taken = metric_2_value;
            double average_speed = metric_3_value;
            double weight = user_weight;
            double cycling_met = 7;

            double result = Math.Round((distance * weight * cycling_met * time_taken), 2);

            return result;
        }
    }


}
