using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        try
        {
            // Read all lines from the CSV file
            string[] csvLines = File.ReadAllLines("data.csv");

            if (csvLines.Length == 0)
            {
                Console.WriteLine("⚠️ Error: CSV file is empty.");
                return;
            }

            // Extract headers
            string[] headers = csvLines[0].Split(',');

            // Create a list to store JSON objects
            List<Dictionary<string, string>> jsonList = new List<Dictionary<string, string>>();

            // Iterate through the remaining lines (actual data)
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] values = csvLines[i].Split(',');

                // Create a dictionary for the current row
                Dictionary<string, string> row = new Dictionary<string, string>();

                // Map headers to values
                for (int j = 0; j < headers.Length; j++)
                {
                    if (j < values.Length) // Ensure no out-of-bounds errors
                        row[headers[j]] = values[j];
                    else
                        row[headers[j]] = ""; // Handle missing values
                }

                jsonList.Add(row);
            }

            // Convert list of dictionaries to JSON
            string json = JsonConvert.SerializeObject(jsonList, Formatting.Indented);

            // Print JSON output
            Console.WriteLine(json);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("⚠️ Error: data.csv file not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("⚠️ Unexpected Error: " + ex.Message);
        }
    }
}
