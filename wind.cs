using System;

class Program1
{
    // calculating the wind temperature using formula
    public static double CalculateWindChill(double temp,double windSpeed){
        
        double res= 35.74 +0.6215*temp +(0.4275 * temp - 35.75) * Math.Pow(windSpeed ,0.16);
        return res;
    }
    static void Main()
    {
        // Taking user input
        Console.Write("Enter the temperature: ");
        int t = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the wind speed: ");
        int w = Convert.ToInt32(Console.ReadLine());

        double result = CalculateWindChill(t,w);

        // Displaying the result
        Console.WriteLine("The wind chill temperature : "+result);
    }
}
