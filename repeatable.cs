using System;
using System.Reflection;

// Define the repeatable BugReport attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

// Apply the attribute multiple times to a method
class Software
{
    [BugReport("Fix memory leak issue")]
    [BugReport("Optimize loop for better performance")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

// Retrieve and print all bug reports using Reflection
class Program
{
    static void Main()
    {
        Type type = typeof(Software);
        MethodInfo method = type.GetMethod("ProcessData");

        if (method != null)
        {
            object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);

            foreach (BugReportAttribute bug in attributes)
            {
                Console.WriteLine("Bug Report: " + bug.Description);
            }
        }
    }
}
