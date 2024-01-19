using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace fitness_pro_software.controllers
{
    public static class ControllerDatabase
    {
        public static string get_user_name_from_db(int userId)
        {
            string result = "";
            string columnName = "Name";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
        public static void update_user_name_in_db(int userId, string newName)
        {
            string columnName = "Name";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWNAME WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWNAME", newName);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int get_age_from_db(int userId)
        {
            int result = 0;
            string columnName = "Age";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
        public static void update_age_in_db(int userId, int newAge)
        {
            string columnName = "Age";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWAGE WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWAGE", newAge);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int get_goal_from_db(int userId)
        {
            int result = 0;
            string columnName = "Goals";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
        public static void update_goal_in_db(int userId, int newGoal)
        {
            string columnName = "Goals";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWGOAL WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWGOAL", newGoal);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int get_calorie_burned_from_db(int userId)
        {
            int result = 0;
            string columnName = "Calories_Burn";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
        public static void update_calorie_burned_in_db(int userId, int newCaloriesBurned)
        {
            string columnName = "Calories_Burn";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWCALORIESBURNED WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWCALORIESBURNED", newCaloriesBurned);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static double get_weight_from_db(int userId)
        {
            double result = 0.0;
            string columnName = "Weight";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
        public static void update_weight_in_db(int userId, double newWeight)
        {
            string columnName = "Weight";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWWIDTH WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWWIDTH", newWeight);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static double get_height_from_db(int userId)
        {
            double result = 0.0;
            string columnName = "Height";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM UsersDataTable WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
        public static void update_height_in_db(int userId, double newHeight)
        {
            string columnName = "Height";

            using (SQLiteConnection connection = DBHelper.GetConnection())
            {
                connection.Open();

                string query = $"UPDATE UsersDataTable SET {columnName} = @NEWHEIGHT WHERE UserId = @USERID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NEWHEIGHT", newHeight);
                    command.Parameters.AddWithValue("@USERID", userId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
