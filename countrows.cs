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
                // Read all records and count them
                var records = csv.GetRecords<Employee>().ToList();
                Console.WriteLine("Total number of records (excluding header): {0}", records.Count);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

// Employee class representing CSV data structure
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}
