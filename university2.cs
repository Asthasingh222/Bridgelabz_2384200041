using System;
using System.Collections.Generic;

class Professor
{
    public string Name { get; private set; }

    public Professor(string name)
    {
        Name = name;
    }
}

class Course
{
    public string CourseName { get; private set; }
    public Professor AssignedProfessor { get; private set; } // Stores the assigned professor

    public Course(string name)
    {
        CourseName = name;
    }

    public void AssignProfessor(Professor prof)
    {
        AssignedProfessor = prof; // Assigns professor to the course
        Console.WriteLine("Professor {0} assigned to {1}", prof.Name, CourseName);
    }
}

class Student
{
    public string Name { get; private set; }

    public Student(string name)
    {
        Name = name;
    }

    public void EnrollCourse(Course course)
    {
        Console.WriteLine("{0} enrolled in {1}", Name, course.CourseName);
    }
}

class Program
{
    static void Main()
    {
        Course math = new Course("Mathematics");
        Student student = new Student("Shreya Mehta");
        Professor prof = new Professor("Dr. Sooraj");

        student.EnrollCourse(math);
        math.AssignProfessor(prof); // Now assigns the professor to the course
    }
}
