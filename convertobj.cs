using System;
using System.Text.Json;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {
        // Creating a Car object
        Car car = new Car { Brand = "Toyota", Model = "Camry", Year = 2023 };

        // Converting Car object to JSON
        string json = JsonSerializer.Serialize(car, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("Car JSON:\n" + json);
    }
}
