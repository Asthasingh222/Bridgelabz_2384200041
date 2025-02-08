using System;

// Base class: Person
public class Person
{
    protected string Name;
    protected int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("This is a person in the school system.");
    }
}

// Subclass: Teacher (inherits from Person)
public class Teacher : Person
{
    private string Subject;

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Subject: " + Subject);
    }
}

// Subclass: Student (inherits from Person)
public class Student : Person
{
    private string Grade;

    public Student(string name, int age, string grade) : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}

// Subclass: Staff (inherits from Person)
public class Staff : Person
{
    private string Position;

    public Staff(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Position: " + Position);
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher("Anurag", 35, "Mathematics");
        Student student = new Student("Vishnu", 16, "10th Grade");
        Staff staff = new Staff("Bhaskar", 45, "Administrator");

        teacher.DisplayRole();
        Console.WriteLine();
        student.DisplayRole();
        Console.WriteLine();
        staff.DisplayRole();
    }
}
