using System;

class Program
{
    /// Converts temperature from Celsius to Fahrenheit.
    static void Main()
    {
        // Taking user input
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Conversion formula to convert from celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The {0} Celsius is {1} Fahrenheit",celsius,fahrenheit);
    }
}
