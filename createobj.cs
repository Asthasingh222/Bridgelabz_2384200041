using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }

    public Student(string s)
    {
        Name = s; // Default value for Name
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        // Dynamically create an instance of Student class
        object studentInstance = Activator.CreateInstance(type,"Astha Singh");

        // Get the 'Display' method
        //way-1
        MethodInfo method = type.GetMethod("Display");
        // Invoke the Display method
        method.Invoke(studentInstance, null);

        //way-2
        ((Student)studentInstance).Display();
    }
}
