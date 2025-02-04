using System;

public class Course
{
    // Instance Variables
    private string courseName;
    private int duration; // in weeks
    private double fee;

    // Class Variable (Shared across all courses)
    private static string instituteName = "GLA University";

    // Constructor
    public Course(string name, int dur, double cost)
    {
        courseName = name;
        duration = dur;
        fee = cost;
    }

    // Instance Method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course: " + courseName + ", Duration: " + duration + " weeks, Fee: " + fee + ", Institute: " + instituteName);
    }

    // Class Method
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }

    public static void Main()
    {
        Course course1 = new Course("MCA", 2, 200000);
        Course course2 = new Course("B-tech", 3, 350000);

        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        Course.UpdateInstituteName("Delhi University");

        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
