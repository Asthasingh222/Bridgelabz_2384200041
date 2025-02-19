using System;

class Program
{
    static void Main()
    {
        // Lambda expression to add two numbers
        Func<int, int, int> add = (x, y) => x + y;

        // Use the lambda expression
        int result = add(5, 3);

        Console.WriteLine("Sum: " + result);  // Output: Sum: 8
    }
}
