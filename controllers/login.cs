using System;
using System.Data.SQLite;

public class LoginUser
{
    public static bool AuthenticateUser(string username, string password)
    {
        using (SQLiteConnection connection = DBHelper.GetConnection())
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM UsersTable WHERE Username = @Username AND Password = @Password";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }
    }

    public static void RegisterUser(string username, string password)
    {
        using (SQLiteConnection connection = DBHelper.GetConnection())
        {
            connection.Open();

            // Find the last UserID from the UsersTable
            string getLastUserIDQuery = "SELECT MAX(UserID) FROM UsersTable";

            using (SQLiteCommand getLastUserIDCmd = new SQLiteCommand(getLastUserIDQuery, connection))
            {
                object lastUserIDObject = getLastUserIDCmd.ExecuteScalar();

                int lastUserID = (lastUserIDObject == DBNull.Value) ? 0 : Convert.ToInt32(lastUserIDObject);

                // Increment the last UserID to generate a new one
                int newUserID = lastUserID + 1;

                // Insert the new user into UsersTable
                string insertUserQuery = "INSERT INTO UsersTable (UserID, Username, Password) VALUES (@UserID, @Username, @Password)";

                using (SQLiteCommand insertUserCmd = new SQLiteCommand(insertUserQuery, connection))
                {
                    insertUserCmd.Parameters.AddWithValue("@UserID", newUserID);
                    insertUserCmd.Parameters.AddWithValue("@Username", username);
                    insertUserCmd.Parameters.AddWithValue("@Password", password);

                    insertUserCmd.ExecuteNonQuery();
                }
            }

        }
    }
}
