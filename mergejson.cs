

using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Two JSON objects
        string json1 = File.ReadAllText("data.json");
        string json2 = File.ReadAllText("data2.json");

        // Parsing JSON objects
        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);

        // Merging the second object into the first
        obj1.Merge(obj2);

        Console.WriteLine("Merged JSON:\n" + obj1.ToString());
    }
}
