using System;

class Program1
{
    // dividing N number of chocolates among M children
    static void Main()
    {
        // Taking user input
        Console.Write("Enter the Number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculating remainning chocolates after distribution
        int rem = numberOfChocolates % numberOfChildren;

        // calculating number of chocolates each student gets
        int res = numberOfChocolates / numberOfChildren;

        // Displaying the result
        Console.WriteLine(" The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}",res,rem);
    }
}
