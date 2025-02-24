using System;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

// Apply the attribute to methods
class Project
{
    [Todo("Fix login issue", "Alice", "HIGH")]
    [Todo("Improve UI", "Bob", "MEDIUM")]
    public void UpdateApp() { }

    [Todo("Refactor database code", "Charlie")]
    public void OptimizeDatabase() { }
}

// Retrieve and print all pending tasks using Reflection
class Program
{
    static void Main()
    {
        Type type = typeof(Project);
        foreach (MethodInfo method in type.GetMethods())
        {
            foreach (TodoAttribute attr in method.GetCustomAttributes(typeof(TodoAttribute), false))
            {
                Console.WriteLine("Task: " + attr.Task + ", Assigned To: " + attr.AssignedTo + ", Priority: " + attr.Priority);
            }
        }
    }
}
