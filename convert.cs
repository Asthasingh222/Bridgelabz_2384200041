using System;

class Program
{
    static void Main()
    {
		Console.WriteLine("Enter Temperature in Celsius:");
		double a = Convert.ToDouble(Console.ReadLine());
		double res = (a* 9/5) +32;
        Console.WriteLine("Temperature in Fahrenheit  : "+ res);
    }
}
