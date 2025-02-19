using System;
using System.Collections.Generic;
using System.Linq;

class Patient
{
    public string Name { get; set; }
    public int Severity { get; set; }
    
    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }
}

class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient("John", 3),
            new Patient("Alice", 5),
            new Patient("Bob", 2)
        };
        
        var sortedPatients = patients.OrderByDescending(p => p.Severity);
        foreach (var patient in sortedPatients)
        {
            Console.WriteLine(patient.Name);
        }
    }
}