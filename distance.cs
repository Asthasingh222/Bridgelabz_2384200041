using System;

class Program
{
    /// Converts distance from feet to yards and miles.
    static void Main()
    {
        Console.Write("Enter distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());//taking input in double
        double yards = distanceInFeet / 3;  //conert distance from feet to yard
        double miles = yards / 1760; //converting to miles
        Console.WriteLine("The distance in yards is " + yards + " and in miles is " + miles);
    }
}
