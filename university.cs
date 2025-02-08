using System;
using System.Collections.Generic;

// Faculty class (Exists independently of any university)
class Faculty
{
    public string Name { get; private set; }

    public Faculty(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Faculty: {0}",Name);
    }
}

// Department class (Composition: Exists only within University)
class Department
{
    public string Name { get; private set; }

    public Department(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("  Department: {0}",Name);
    }
}

// University class (Composition: Deleting University deletes Departments)
class University
{
    public string Name { get; private set; }
    private List<Department> departments = new List<Department>();
    private List<Faculty> faculties = new List<Faculty>(); // Aggregation

    public University(string name)
    {
        Name = name;
    }

    public void AddDepartment(string deptName)
    {
        departments.Add(new Department(deptName));
    }

    public void AddFaculty(Faculty faculty) // Aggregation
    {
        faculties.Add(faculty);
    }

    public void Display()
    {
        Console.WriteLine("University: {0}",Name);
        foreach (var dept in departments)
        {
            dept.Display();
        }
        Console.WriteLine("Faculties:");
        foreach (var faculty in faculties)
        {
            faculty.Display();
        }
    }

    public void DeleteUniversity()
    {
        departments.Clear(); // Deleting all departments
        Console.WriteLine("{0} and all its departments are deleted.",Name);
    }
}

class Program
{
    static void Main()
    {
        University uni = new University("Delhi University");

        // Adding departments (Composition)
        uni.AddDepartment("Computer Science");
        uni.AddDepartment("Mathematics");

        // Creating faculty members (Aggregation)
        Faculty prof1 = new Faculty("Dr. Sanjana");
        Faculty prof2 = new Faculty("Dr. Rishabh");

        // Adding faculties to the university (but they exist independently)
        uni.AddFaculty(prof1);
        uni.AddFaculty(prof2);

        uni.Display();

        // Deleting the university (Departments should be deleted, but faculties exist)
        uni.DeleteUniversity();
        
    }
}