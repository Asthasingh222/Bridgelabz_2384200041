using System;

class Program
{
    /// Converts temperature from Fahrenheit to Celsius.
    static void Main()
    {
        // Taking user input
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Conversion formula from fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("The {0} Fahrenheit is {1} Celsius",fahrenheit,celsius);
    }
}
