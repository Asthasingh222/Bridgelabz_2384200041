using System;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

// Apply the attribute to methods
class SampleClass
{
    [ImportantMethod("HIGH")]
    public void CriticalTask()
    {
        Console.WriteLine("Performing a critical task.");
    }

    [ImportantMethod("MEDIUM")]
    public void NormalTask()
    {
        Console.WriteLine("Performing a normal task.");
    }
}

// Retrieve and print annotated methods using Reflection
class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);
        foreach (MethodInfo method in type.GetMethods())
        {
            ImportantMethodAttribute attr = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));

            if (attr != null)
            {
                Console.WriteLine("Method: " + method.Name + ", Importance Level: " + attr.Level);
            }
        }
    }
}
