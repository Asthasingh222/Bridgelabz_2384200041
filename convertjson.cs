using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

class Program
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }

    static void Main()
    {
        string jsonFile = "C:\\Users\\astha\\source\\repos\\countrowscsv\\countrowscsv\\abc.json";
        string csvFile = "studentscon.csv";

        // Convert JSON to CSV
        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(jsonFile));
        using (var writer = new StreamWriter(csvFile))
        {
            writer.WriteLine("ID,Name,Age,Grade"); // Header
            foreach (var student in students)
            {
                writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Grade}");
            }
        }
        Console.WriteLine($"CSV file created: {csvFile}");

        // Convert CSV back to JSON
        var csvLines = File.ReadAllLines(csvFile);
        List<Student> newStudents = new List<Student>();

        for (int i = 1; i < csvLines.Length; i++) // Skip header row
        {
            var columns = csvLines[i].Split(',');
            newStudents.Add(new Student
            {
                ID = int.Parse(columns[0]),
                Name = columns[1],
                Age = int.Parse(columns[2]),
                Grade = columns[3]
            });
        }

        File.WriteAllText("students_converted.json", JsonConvert.SerializeObject(newStudents, Newtonsoft.Json.Formatting.Indented));
        Console.WriteLine("JSON file created from CSV: students_converted.json");
    }
}
