using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            // Read JSON schema and JSON data from files
            string schemaText = File.ReadAllText("schema.json");
            string jsonString = File.ReadAllText("data.json");

            // Parse JSON Schema
            JSchema schema = JSchema.Parse(schemaText);

            // Parse JSON Data
            JObject jsonData = JObject.Parse(jsonString);

            // Validate JSON against schema
            IList<string> validationErrors = new List<string>();
            bool isValid = jsonData.IsValid(schema, out validationErrors);

            // Print validation result
            if (isValid)
            {
                Console.WriteLine("JSON is valid!");
            }
            else
            {
                Console.WriteLine("Invalid JSON! Errors:");
                foreach (string error in validationErrors)
                {
                    Console.WriteLine("- " + error);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
