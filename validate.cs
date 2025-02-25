using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CsvHelper;
using CsvHelper.Configuration;

// Define an Employee class to represent CSV records
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

class Program
{
    static void ValidateCSV(string filename)
    {
        // Regular expressions for validation
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";  // Basic Email Format
        string phonePattern = @"^\d{10}$";  // Must be exactly 10 digits

        try
        {
            // Open CSV file for reading
            using (var reader = new StreamReader(filename))
            using (var csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csvReader.GetRecords<Employee>().ToList();  // Read all records into a list

                // Iterate through each record and validate email and phone
                foreach (var emp in records)
                {
                    bool validEmail = Regex.IsMatch(emp.Email, emailPattern);
                    bool validPhone = Regex.IsMatch(emp.Phone, phonePattern);

                    if (!validEmail || !validPhone)
                    {
                        Console.WriteLine($"Invalid record: {emp.Name}, Email: {emp.Email}, Phone: {emp.Phone}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

    static void Main()
    {
        string filename = "file2.csv";  // CSV file containing employees' details
        ValidateCSV(filename);
    }
}
