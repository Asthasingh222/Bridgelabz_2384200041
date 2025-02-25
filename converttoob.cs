using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

// Define the Student class that maps to the CSV columns
class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Grade: {Grade}";
    }
}

class Program
{
    static void Main()
    {
        string filename = "students.csv"; // Ensure the file exists

        try
        {
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                // Read CSV and convert it into a List<Student>
                List<Student> students = new List<Student>(csv.GetRecords<Student>());

                // Print all student objects
                Console.WriteLine("Students Data:");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading CSV: {ex.Message}");
        }
    }
}
