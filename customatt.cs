using System;
using System.Reflection;

// 1️⃣ Define Custom Attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

// 2️⃣ Apply Attribute to a Method
class TaskManager
{
    [TaskInfo(1, "Astha")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

// 3️⃣ Retrieve Attribute Details Using Reflection
class Program
{
    static void Main()
    {
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("CompleteTask");

        if (method != null)
        {
            // Get custom attribute
            TaskInfoAttribute attribute = (TaskInfoAttribute)Attribute.GetCustomAttribute(method, typeof(TaskInfoAttribute));

            if (attribute != null)
            {
                Console.WriteLine("Task Priority: {0}",attribute.Priority);
                Console.WriteLine("Assigned To: {0}",attribute.AssignedTo);
            }
        }
    }
}
