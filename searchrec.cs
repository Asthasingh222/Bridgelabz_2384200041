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
    static void SearchEmployee(string filename, string searchName)
    {
        try
        {
            // Open the CSV file for reading
            using (var reader = new StreamReader("file.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Read all records into a list
                var records = csv.GetRecords<Employee>().ToList();

                // Search for employees matching the name (case-insensitive, allows partial matches)
                var matchedEmployees = records.Where(e => e.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (matchedEmployees.Any())
                {
                    // Print all matched employees
                    foreach (var employee in matchedEmployees)
                    {
                        Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
                    }
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }

    static void Main()
    {
        Console.Write("Enter employee name to search: ");
        string name = Console.ReadLine();

        string filename = "employees.csv"; // Ensure the correct filename is used
        SearchEmployee(filename, name);
    }
}
