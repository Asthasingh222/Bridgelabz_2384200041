using System;
using System.Collections.Generic;

// Course class (Students enroll in multiple courses)
class Course
{
    public string CourseName { get; private set; }
    public List<Student> EnrolledStudents { get; private set; } 

    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    // Enroll a student in this course
    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
            student.EnrollInCourse(this); // Ensuring the student also adds this course
        }
    }

    // Display students enrolled in the course
    public void DisplayEnrolledStudents()
    {
        Console.WriteLine("Course: {0} - Enrolled Students:",CourseName);
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine("- {0}",student.Name);
        }
    }
}

// Student class (Can enroll in multiple courses)
class Student
{
    public string Name { get; private set; }
    public List<Course> Courses { get; private set; }

    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    // Enroll in a course
    public void EnrollInCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            course.EnrollStudent(this); // Ensuring the course also registers this student
        }
    }

    // Display courses the student is enrolled in
    public void DisplayEnrolledCourses()
    {
        Console.WriteLine("{0} is enrolled in:",Name);
        foreach (var course in Courses)
        {
            Console.WriteLine("- {0}",course.CourseName);
        }
    }
}

// School class (Aggregates students, but they can exist independently)
class School
{
    public string SchoolName { get; private set; }
    public List<Student> Students { get; private set; }

    public School(string schoolName)
    {
        SchoolName = schoolName;
        Students = new List<Student>();
    }

    // Add a student to the school
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void DisplayStudents()
    {
        Console.WriteLine("School: {0} - Students:",SchoolName);
        foreach (var student in Students)
        {
            Console.WriteLine("- {0}",student.Name);
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating a school
        School school = new School("St. Paul's School");

        // Creating students
        Student student1 = new Student("Anushka");
        Student student2 = new Student("Charu");

        // Creating courses
        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        // Enrolling students in courses (Many-to-Many Relationship)
        student1.EnrollInCourse(math);
        student1.EnrollInCourse(science);
        student2.EnrollInCourse(math);

        // Adding students to the school (Aggregation)
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Displaying data
        school.DisplayStudents();
        student1.DisplayEnrolledCourses();
        student2.DisplayEnrolledCourses();
        math.DisplayEnrolledStudents();
        science.DisplayEnrolledStudents();
    }
}
