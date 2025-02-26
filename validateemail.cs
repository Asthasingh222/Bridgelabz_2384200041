using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        try
        {
            // JSON Schema with Email Validation (Double Quotes)
            string schemaText = @"{
                ""type"": ""object"",
                ""properties"": {
                    ""email"": { ""type"": ""string"", ""pattern"": ""^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"" }
                },
                ""required"": [""email""]
            }";

            // Read JSON file
            string jsonString = File.ReadAllText("users.json");

            // Check if JSON is an array
            JArray jsonArray = JArray.Parse(jsonString);

            // Parse schema
            JSchema schema = JSchema.Parse(schemaText);

            // Validate each item in the array
            foreach (JObject jsonData in jsonArray)
            {
                IList<string> validationErrors = new List<string>();
                bool isValid = jsonData.IsValid(schema, out validationErrors);

                if (isValid)
                {
                    Console.WriteLine($"✅ Valid email: {jsonData["email"]}");
                }
                else
                {
                    Console.WriteLine($"❌ Invalid email: {jsonData["email"]}");
                    foreach (var error in validationErrors)
                    {
                        Console.WriteLine("- " + error);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("⚠️ Error: " + ex.Message);
        }
    }
}
