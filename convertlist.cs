using System;
using System.Text.Json;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Creating a list of Person objects
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 }
        };

        // Converting list to JSON array
        string json = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("List of People JSON:\n" + json);
    }
}
