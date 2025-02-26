using System;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a Student JSON object
        var student = new
        {
            Name = "Alice",
            Age = 22,
            Subjects = new List<string> { "Math", "Physics", "Chemistry" }
        };

        // Convert the object to JSON format
        string json = JsonSerializer.Serialize(student, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("Student JSON:\n" + json);
    }
}
