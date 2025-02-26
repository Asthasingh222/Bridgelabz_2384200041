using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonString = File.ReadAllText("data.json");
        JObject jsonData = JObject.Parse(jsonString);

        Console.WriteLine("JSON Data:");
        foreach (var item in jsonData)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
