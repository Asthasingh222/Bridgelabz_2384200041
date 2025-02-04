using System;

class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Roll No: {RollNumber}, Name: {Name}, CGPA: {GetCGPA()}");
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa) : base(rollNumber, name, cgpa) { }

    public void ShowStudent()
    {
        Console.WriteLine($"PG Student Name: {Name}");
    }
}

static class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "John", 3.8);
        s1.DisplayDetails();
        PostgraduateStudent pg = new PostgraduateStudent(102, "Alice", 4.0);
        pg.ShowStudent();
    }
}
