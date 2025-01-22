using System;

class Program
{
    static void Main()
    {
        //converting weight from pound to kilograms
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());


        //formula to convert from pound to kilograms
        double kg = pounds/2.2;

        Console.WriteLine("The weight of the person in pounds is {0} and in kg is {1}",pounds,kg);
    }
}
