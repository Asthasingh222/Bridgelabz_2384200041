using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using System.Formats.Asn1;

class CountCSVRecords
{
    static void Main()
    {
        try
        {
            // Open and read the CSV file
            using (var reader = new StreamReader("file.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Read all records
                var records = csv.GetRecords<Student>().Where(s => s.Marks > 80).ToList();
                // Display filtered records
                Console.WriteLine("Students who scored more than 80 marks:");
                foreach (var record in records)
                {
                    Console.WriteLine($"ID: {record.ID}, Name: {record.Name}, Marks: {record.Marks}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

// Student class representing CSV data structure
public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Marks { get; set; }
}
