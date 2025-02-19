using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 100000 };
        string target = "Hello";

        foreach (var size in sizes)
        {
            Console.WriteLine("Testing with " + size + " string concatenations");

            // Using string
            Stopwatch stopwatch = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < size; i++)
            {
                str += target;
            }
            stopwatch.Stop();
            Console.WriteLine("String Concatenation: " + stopwatch.ElapsedMilliseconds + "ms");

            // Using StringBuilder
            stopwatch.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                sb.Append(target);
            }
            stopwatch.Stop();
            Console.WriteLine("StringBuilder: " + stopwatch.ElapsedMilliseconds + "ms");

        }
    }
}
