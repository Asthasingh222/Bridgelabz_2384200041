using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Collections.Generic;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void UpdateSalary(string filename, string dstname)
    {
        try
        {
            // Open the CSV file for reading
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Read all records into a list
                var records = csv.GetRecords<Employee>().ToList();

                // Increase salary by 10% for employees in the "IT" department
                foreach (var emp in records)
                {
                    if (emp.Department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        emp.Salary *= 1.10m; // Increase by 10%
                    }
                }
       
                // Write updated data to a new CSV file
                using (var writer = new StreamWriter(dstname))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(records);
                }

                Console.WriteLine("Updated salaries saved to: " + dstname);
           
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing the file: {ex.Message}");
        }

    }

    static void Main()
    {
        
        string filename = "file.csv"; // Ensure the correct filename is used
        string dstname = "output.csv";
        UpdateSalary(filename, dstname);
    }
}
