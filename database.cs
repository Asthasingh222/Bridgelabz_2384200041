using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.IO;

// Define a User class to store database records
class User
{
    public int Id { get; set; }      // Unique ID for each user
    public string Name { get; set; } // Name of the user
    public int Age { get; set; }     // Age of the user
    public string Email { get; set; } // Email address
}

class Program
{
    static void Main()
    {
        // SQLite database connection string
        string connectionString = "Data Source=users.db;Version=3;";

        // List to store user records
        List<User> users = new List<User>();

        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open(); // Open the SQLite connection

            // Query to fetch all records from the Users table
            string selectQuery = "SELECT * FROM Users";

            using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    // Read each row from the database and add to the users list
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Id = Convert.ToInt32(reader["Id"]),  // Convert ID to integer
                            Name = reader["Name"].ToString(),   // Read name
                            Age = Convert.ToInt32(reader["Age"]), // Convert Age to integer
                            Email = reader["Email"].ToString()  // Read email
                        });
                    }
                }
            }
        }

        // Convert the users list to JSON format with proper indentation
        string jsonReport = JsonConvert.SerializeObject(users, Formatting.Indented);

        // Save the JSON output to a file named 'report.json'
        File.WriteAllText("report.json", jsonReport);

        // Print a success message
        Console.WriteLine("✅ JSON report generated successfully! Check 'report.json'.");
    }
}
