using System;

class Student
{
    private static string universityName = "GLA University";
    private static int totalStudents = 0;
    private readonly int rollNumber;
    private string name;
    private char grade;

    // Getter methods for private fields
    public static string GetUniversityName()
    {
        return universityName;
    }

    public int GetRollNumber()
    {
        return rollNumber;
    }

    public string GetName()
    {
        return name;
    }

    public char GetGrade()
    {
        return grade;
    }

    // Constructor
    public Student(int rollNumber, string name, char grade)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.grade = grade;
        totalStudents++;
    }

    // Static method to get total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Number of Students: " + totalStudents);
    }

    // Instance method to display student details
    public void DisplayDetails()
    {
        Console.WriteLine("Roll No: " + GetRollNumber() + ", Name: " + GetName() +
                          ", CGPA: " + GetGrade() + ", University Name: " + GetUniversityName());
    }
}

static class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "Kartik", 'A');
        if (s1 is Student) s1.DisplayDetails();
        Student.DisplayTotalStudents();

        Student s2 = new Student(104, "Krati", 'C');
        if (s2 is Student) s2.DisplayDetails();
        Student.DisplayTotalStudents();
    }
}
