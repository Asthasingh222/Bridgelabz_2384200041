using System;

class Program
{
    //function to return sum of n natural numbers
    static double Sum(int n){
        double sum = 0;

            // Sum using for loop
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
            
    }
    static void Main()
    {
        //prompt to take input a number
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum of {0} natural number : {1}",n,Sum(n));
    }
}
