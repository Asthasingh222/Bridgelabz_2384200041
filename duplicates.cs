using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void FindDuplicates(string filename)
    {
        try
        {
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                // Read all records into a list
                var records = csv.GetRecords<Student>().ToList();

                // Group by ID and find duplicates
                var duplicates = records.GroupBy(r => r.ID)
                                        .Where(g => g.Count() > 1)
                                        .SelectMany(g => g);

                if (!duplicates.Any())
                {
                    Console.WriteLine("No duplicate records found.");
                    return;
                }

                Console.WriteLine("Duplicate Records Found:");
                Console.WriteLine("-------------------------");

                // Print duplicate records
                foreach (var dup in duplicates)
                {
                    Console.WriteLine($"ID: {dup.ID}, Name: {dup.Name}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading CSV: {ex.Message}");
        }
    }

    static void Main()
    {
        FindDuplicates("students.csv"); // Specify the CSV file
    }
}
