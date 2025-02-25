using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

// Define Student class for merged data
class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }
}

// Define a separate class for reading students2.csv (Marks & Grade)
class StudentMarks
{
    public int ID { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }
}

class Program
{
    static void MergeCSV(string file1, string file2, string outputFile)
    {
        var students1 = new Dictionary<int, Student>(); // Dictionary to store first file records
        var students2 = new Dictionary<int, StudentMarks>(); // Dictionary for second file

        try
        {
            // Read first CSV file (ID, Name, Age)
            using (var reader = new StreamReader(file1))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,    // Ignore header validation
                MissingFieldFound = null   // Ignore missing fields
            }))
            {
                foreach (var student in csv.GetRecords<Student>())
                {
                    students1[student.ID] = student; // Store records in dictionary
                }
            }

            // Read second CSV file (ID, Marks, Grade)
            using (var reader = new StreamReader(file2))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,    // Ignore header validation
                MissingFieldFound = null   // Ignore missing fields
            }))
            {
                foreach (var record in csv.GetRecords<StudentMarks>())
                {
                    students2[record.ID] = record;
                }
            }

            // Merge the data using ID as the key
            foreach (var id in students2.Keys)
            {
                if (students1.ContainsKey(id))
                {
                    students1[id].Marks = students2[id].Marks;
                    students1[id].Grade = students2[id].Grade;
                }
            }

            // Write merged data to a new CSV file
            using (var writer = new StreamWriter(outputFile))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(students1.Values);
            }

            Console.WriteLine("CSV files merged successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing CSV files: {ex.Message}");
        }
    }

    static void Main()
    {
        MergeCSV("students1.csv", "students2.csv", "merged_students.csv"); // Merge the two files
    }
}
