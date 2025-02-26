using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonString = File.ReadAllText("users.json");
        JArray users = JArray.Parse(jsonString);

        var filteredUsers = users.Where(user => (int)user["age"] > 25);

        Console.WriteLine("Users older than 25:");
        foreach (var user in filteredUsers)
        {
            Console.WriteLine(user.ToString());
        }
    }
}
