using System;
using System.Collections.Generic;

// Abstract class representing a course type
abstract class CourseType
{
    public string courseName { get; set; }

    public CourseType(string name)
    {
        courseName = name;
    }

    // Abstract method for evaluation
    public abstract void EvaluateCourse();
}

// Specific course type: Exam-based courses
class ExamCourse : CourseType
{
    public ExamCourse() : base("Exam Course") { }

    public override void EvaluateCourse()
    {
        Console.WriteLine("Evaluating based on Exams.");
    }
}

// Specific course type: Assignment-based courses
class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("Assignment Course") { }

    public override void EvaluateCourse()
    {
        Console.WriteLine("Evaluating based on Assignments.");
    }
}

// Generic class to manage different types of courses
class Course<T> where T : CourseType
{
    public string name { get; set; }
    public T type { get; set; }

    public Course(string name, T type)
    {
        this.name = name;
        this.type = type;
    }

    // Display course details
    public void DisplayCourse()
    {
        Console.WriteLine("Course Name: " + name);
        Console.WriteLine("Course Type: " + type.courseName);
    }
}

// University class to manage courses dynamically
class University
{
    private List<object> courses = new List<object>(); // Using object to handle multiple generic types

    // Add a new course to the university
    public void AddCourse<T>(Course<T> course) where T : CourseType
    {
        courses.Add(course);
    }

    // Display all courses and their evaluations
    public void DisplayAllCourses()
    {
        Console.WriteLine("\nUniversity Courses:");
        foreach (var course in courses)
        {
            // Use dynamic typing to call the correct method
            dynamic dynamicCourse = course;
            dynamicCourse.DisplayCourse();
            dynamicCourse.type.EvaluateCourse();
            Console.WriteLine(); // New line for readability
        }
    }
}

// Main program
class Program
{
    public static void Main()
    {
        // Create courses
        Course<ExamCourse> ex = new Course<ExamCourse>("Mathematics", new ExamCourse());
        Course<AssignmentCourse> ass = new Course<AssignmentCourse>("Python Programming", new AssignmentCourse());

        // Create university and add courses
        University uv = new University();
        uv.AddCourse(ex);
        uv.AddCourse(ass);

        // Display all courses
        uv.DisplayAllCourses();
    }
}
