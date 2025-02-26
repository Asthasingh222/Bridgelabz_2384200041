using System;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string jsonString = File.ReadAllText("data.json");
        XNode xml = JsonConvert.DeserializeXNode(jsonString, "Root");

        Console.WriteLine(xml.ToString());
    }
}
