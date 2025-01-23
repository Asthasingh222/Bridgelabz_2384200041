using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter two numbers
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());

        // Prompt the user to enter an operator
        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Perform the operation based on the operator
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: {0}", first + second);
                break;
            case "-":
                Console.WriteLine("Result: {0}", first - second);
                break;
            case "*":
                Console.WriteLine("Result: {0}", first * second);
                break;
            case "/":
                if (second != 0)
                    Console.WriteLine("Result: {0}", first / second);
                else
                    Console.WriteLine("Error: Division by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
