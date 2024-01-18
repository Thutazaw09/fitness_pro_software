using System;
using System.IO;
using System.Data.SQLite;


public static class DBHelper
{
    public static string constring = @"Data Source = ..\..\..\database\fitness.db;Version=3;";

    public static void InitializeDatabase()
    {
        if (!File.Exists(@"..\..\..\database\fitness.db"))
        {
            SQLiteConnection.CreateFile(@"..\..\..\database\fitness.db");
             
            using (var db = new SQLiteConnection(constring)) 
            {  
                db.Open();

                string createUsersTable = @"CREATE TABLE IF NOT EXISTS UsersTable (
                                            UserID INTEGER PRIMARY KEY,
                                            Username TEXT NOT NULL,
                                            Password TEXT NOT NULL
                                            );";

                string createUsersDataTable = @"CREATE TABLE IF NOT EXISTS UsersDataTable (
                                            UserID INTEGER,
                                            Weight DECIMAL(5,2),
                                            Height DECIMAL(5,2),
                                            Goals INTEGER,
                                            Calories_Burn INTEGER,
                                            Name TEXT(100),
                                            Age INTEGER,
                                            FOREIGN KEY (UserID) REFERENCES UsersTable(UserID)
                                            );";

                using (var cmd = new SQLiteCommand(db))
                {
                    cmd.CommandText = createUsersTable;
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = createUsersDataTable;
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }

    public static SQLiteConnection GetConnection() 
    {
        return new SQLiteConnection(constring);
    }
}
