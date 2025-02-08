using System;

// Base class: Course
public class Course
{
    public string CourseName { get; private set; }
    public int Duration { get; private set; }

    public Course(string name, int duration)
    {
        CourseName = name;
        Duration = duration;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Course: {0}, Duration: {1} weeks",CourseName,Duration);
    }
}

// Subclass: OnlineCourse (inherits from Course)
public class OnlineCourse : Course
{
    public string Platform { get; private set; }
    public bool IsRecorded { get; private set; }

    public OnlineCourse(string name, int duration, string platform, bool recorded)
        : base(name, duration)
    {
        Platform = platform;
        IsRecorded = recorded;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Platform: {0}, Recorded: {1}",Platform,IsRecorded);
    }
}

// Subclass: PaidOnlineCourse (inherits from OnlineCourse)
public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; private set; }
    public double Discount { get; private set; }

    public PaidOnlineCourse(string name, int duration, string platform, bool recorded, double fee, double discount)
        : base(name, duration, platform, recorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Fee: {0:C}, Discount: {1}%",Fee,Discount);
    }
}

class Program
{
    static void Main()
    {
        PaidOnlineCourse course = new PaidOnlineCourse("C# Basics", 6, "Udemy", true, 99.99, 10);
        course.DisplayDetails();
    }
}
