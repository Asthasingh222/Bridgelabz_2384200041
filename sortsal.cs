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

                //sort by salary in descending order and take the top 5
                var topEmployees =records.OrderByDescending(x => x.Salary).ToList();

                //Print top 5 employees
                Console.WriteLine("Top 5 Highest-Paid Employees:");
                Console.WriteLine("-------------------------------------");
                foreach(var employee in topEmployees)
                {
                    Console.WriteLine($"ID:{employee.ID},Name: {employee.Name},Department: {employee.Department},Salary: {employee.Salary}");
                }
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
