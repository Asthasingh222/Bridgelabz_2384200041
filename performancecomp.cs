using System;
using System.Text;

class PerformanceTest
{
    static void Main()
    {
        long startTime, endTime;

        // Testing String Performance
        startTime = DateTime.Now.Ticks;
        string str = "C#";
        for (int i = 0; i < 10000; i++)
        {
            str += " Performance Test";
        }
        endTime = DateTime.Now.Ticks;
        Console.WriteLine("String Time: " + (endTime - startTime) + " ticks");

        // Testing StringBuilder Performance
        startTime = DateTime.Now.Ticks;
        StringBuilder sb = new StringBuilder("C#");
        for (int i = 0; i < 10000; i++)
        {
            sb.Append(" Performance Test");
        }
        endTime = DateTime.Now.Ticks;
        Console.WriteLine("StringBuilder Time: " + (endTime - startTime) + " ticks");
    }
}
