using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        List<User> users = new List<User>
        {
            new User { Name = "Alice", Age = 25, Email = "alice@example.com" },
            new User { Name = "Bob", Age = 30, Email = "bob@example.com" }
        };

        string jsonArray = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine(jsonArray);
    }
}
