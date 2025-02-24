using System;
using System.Diagnostics;
using System.Reflection;

class PerformanceMonitor
{
    public static void MeasureExecutionTime(object instance, string methodName)
    {
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(instance, null); // Invoke the method dynamically
            stopwatch.Stop();

            long elapsedTicks = stopwatch.ElapsedTicks; // More precise
            double elapsedMs = stopwatch.Elapsed.TotalMilliseconds; // Higher precision

            Console.WriteLine("Execution time of " + methodName + ": " + elapsedMs + " ms (" + elapsedTicks + " ticks)");
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}

// Sample class
class Calculator
{
    public void HeavyComputation()
    {
        for (int i = 0; i < 10000000; i++) { } // Simulating heavy computation
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        PerformanceMonitor.MeasureExecutionTime(calculator, "HeavyComputation");
    }
}
