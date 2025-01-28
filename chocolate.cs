using System;

class Program1
{
    // dividing N number of chocolates among M children
    public static int[] Distribution(int a,int b){
        // Calculating remainning chocolates after distribution
        int r1 = a % b;

        // calculating number of chocolates each student gets
        int r2 = a / b;
        return new int[] {r1,r2};

    }
    static void Main()
    {
        // Taking user input
        Console.Write("Enter the Number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int rem = Distribution(numberOfChocolates,numberOfChildren)[0];
        int res = Distribution(numberOfChocolates,numberOfChildren)[1];

        // Displaying the result
        Console.WriteLine(" The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}",res,rem);
    }
}
