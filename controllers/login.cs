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
}
