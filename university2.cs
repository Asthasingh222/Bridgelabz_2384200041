using System;

public class Student
{
    public int rollNumber;  // Public
    protected string name;  // Protected
    private double cgpa;    // Private

    // Constructor
    public Student(int roll, string studentName, double studentCgpa)
    {
        rollNumber = roll;
        name = studentName;
        cgpa = studentCgpa;
    }

    // Public Methods to Access CGPA
    public double GetCGPA()
    {
        return cgpa;
    }

    public void SetCGPA(double newCgpa)
    {
        cgpa = newCgpa;
    }
}

// Subclass accessing protected member
public class PostgraduateStudent : Student
{
    public PostgraduateStudent(int roll, string studentName, double studentCgpa) : base(roll, studentName, studentCgpa) { }

    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name);
    }
}

public class Program
{
    public static void Main()
    {
        PostgraduateStudent pgStudent = new PostgraduateStudent(13, "Astha Singh Jadon", 8.13);
        pgStudent.DisplayStudent();
        Console.WriteLine("CGPA: " + pgStudent.GetCGPA());
    }
}
