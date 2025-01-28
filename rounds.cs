using System;

class Program
{
    //function to calculate number of rounds taken to complete 5km
     static int CalculateRounds(double perimeter, double distance)
    {
        return (int)Math.Ceiling(distance / perimeter);
    }
    static void Main(string[] args)
    {
        //prompt to input sides of triangle
        Console.Write("Enter the lengths of three sides of the park (in meters): ");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        int rounds = CalculateRounds(perimeter, 5000);
        Console.WriteLine("The athlete needs to complete {0} rounds to run 5 km.",rounds);
    }

}
