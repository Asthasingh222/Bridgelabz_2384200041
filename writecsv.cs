using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;

// Class to demonstrate writing CSV using CsvHelper
class WriteCSVUsingCsvHelper
{
    static void Main()
    {
        // Using StreamWriter to create and write to the CSV file
        using (var writer = new StreamWriter("output.csv"))
        // Initializing CsvWriter with CultureInfo.InvariantCulture for consistent formatting
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            // Creating a list of Employee objects to be written to the CSV file
            var records = new List<Employee>
            {
                new Employee { ID = 104, Name = "Alice Williams", Department = "Finance", Salary = 62000 },
                new Employee { ID = 105, Name = "Bob Johnson", Department = "Sales", Salary = 58000 }
            };

            // Writing the list of employee records to the CSV file
            csv.WriteRecords(records);
        }

        // Informing the user that the CSV file has been written successfully
        Console.WriteLine("CSV file written successfully using CsvHelper!");
    }
}

// Employee class representing the structure of CSV data
public class Employee
{
    public int ID { get; set; }          // Employee ID
    public string Name { get; set; }     // Employee Name
    public string Department { get; set; }  // Employee Department
    public decimal Salary { get; set; }  // Employee Salary
}
