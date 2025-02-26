using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Read JSON file
            string jsonString = File.ReadAllText("users.json");

            // Parse JSON as JArray (Array of JSON objects)
            JArray users = JArray.Parse(jsonString);

            // Filter users where age > 25
            IEnumerable<JObject> filteredUsers = users.Where(user => (int)user["age"] > 25);

            Console.WriteLine("Users with age > 25:");
            foreach (var user in filteredUsers)
            {
                Console.WriteLine(user.ToString(Formatting.Indented));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("⚠️ Error: " + ex.Message);
        }
    }
}
