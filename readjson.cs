using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Define the path to the JSON file
        string filePath = "data.json";

        try
        {
            // Step 1: Read the entire JSON file content into a string
            string jsonString = File.ReadAllText(filePath);

            // Step 2: Deserialize the JSON string into a dynamic object
            // 'dynamic' allows accessing properties without defining a class
            dynamic user = JsonConvert.DeserializeObject<dynamic>(jsonString);

            // Step 3: Access and print specific fields (name and email)
            Console.WriteLine(user.name);
            Console.WriteLine(user.email);
        }
        catch (Exception ex)
        {
            // Handle errors if the file is missing or contains invalid JSON
            Console.WriteLine("Error reading JSON file: " + ex.Message);
        }
    }
}
