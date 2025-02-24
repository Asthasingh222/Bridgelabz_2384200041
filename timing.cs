using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

class PerformanceMonitor
{
    public static void MeasureExecutionTime(object instance, string methodName)
    {
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        if (method != null)
        {
            Stopwatch stopwatch = new Stopwatch();

            try
            {
                stopwatch.Start();
                method.Invoke(instance, null); // Dynamically invoke method
                stopwatch.Stop();

                Console.WriteLine("Execution time of " + methodName + ": " + stopwatch.ElapsedMilliseconds + " ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing method: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Method not found: " + methodName);
        }
    }
}

// Sample class
class Calculator
{
    public void Compute()
    {
        // Simulating work
        Thread.Sleep(10); 
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        PerformanceMonitor.MeasureExecutionTime(calculator, "Compute");
    }
}
