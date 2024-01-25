using System.Data.SQLite;

namespace fitness_pro_software.controllers
{
    public static class ControllerDatabase
    {
        public static string GetUserNameFromDb(int userId)
        {
            string result = "";
            string columnName = "Name";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@USERID", userId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader[columnName].ToString();
                        }

                    }
                }
            }

            return result;
        }
        public static void UpdateUserNameInDb(int userId, string newName)
        {
            string columnName = "Name";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWNAME WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWNAME", newName);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetAgeFromDb(int userId)
        {
            int result = 0;
            string columnName = "Age";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@USERID", userId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            result = Convert.ToInt32(reader[columnName]);
                        }
                    }
                }
            }

            return result;
        }
        public static void UpdateAgeInDb(int userId, int newAge)
        {
            string columnName = "Age";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWAGE WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWAGE", newAge);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetGoalFromDb(int userId)
        {
            int result = 0;
            string columnName = "Goals";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@USERID", userId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            result = Convert.ToInt32(reader[columnName]);
                        }
                    }
                }
            }

            return result;
        }
        public static void UpdateGoalInDb(int userId, int newGoal)
        {
            string columnName = "Goals";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWGOAL WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWGOAL", newGoal);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetCalorieBurnedFromDb(int userId)
        {
            int result = 0;
            string columnName = "Calories_Burn";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@USERID", userId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            result = Convert.ToInt32(reader[columnName]);
                        }
                    }
                }
            }

            return result;
        }
        public static void UpdateCalorieBurnedInDb(int userId, int newCaloriesBurned)
        {
            string columnName = "Calories_Burn";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWCALORIESBURNED WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWCALORIESBURNED", newCaloriesBurned);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static double GetWeightFromDb(int userId)
        {
            double result = 0.0;
            string columnName = "Weight";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@USERID", userId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            result = Convert.ToDouble(reader[columnName]);
                        }
                    }
                }
            }

            return result;
        }
        public static void UpdateWeightInDb(int userId, double newWeight)
        {
            string columnName = "Weight";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWWIDTH WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWWIDTH", newWeight);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static double GetHeightFromDb(int userId)
        {
            double result = 0.0;
            string columnName = "Height";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@USERID", userId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            result = Convert.ToDouble(reader[columnName]);
                        }
                    }
                }
            }

            return result;
        }
        public static void UpdateHeightInDb(int userId, double newHeight)
        {
            string columnName = "Height";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWHEIGHT WHERE UserId = @USERID";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWHEIGHT", newHeight);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
