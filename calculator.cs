using System;

class BasicCalculator
{
    // Function for Addition
    static double Add(double a, double b){
        return a + b;
    }
    // Function for Subtraction
    static double Subtract(double a, double b){
        return a - b;
    }
    // Function for Multiplication
    static double Multiply(double a, double b){
        return a * b;
    }
    // Function for Division (with error handling for division by zero)
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error! Division by zero is not allowed.");
            return double.NaN;
        }
        return a / b;
    }

    static void Main()
    {
        Console.WriteLine("Select operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        
        Console.Write("Enter choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                Console.WriteLine("Result: {0} + {1} = {2}",num1,num2,result);
                break;
            case 2:
                result = Subtract(num1, num2);
                Console.WriteLine("Result: {0} - {1} = {2}",num1,num2,result);
                break;
            case 3:
                result = Multiply(num1, num2);
                Console.WriteLine("Result: {0} * {1} = {2}",num1,num2,result);
                break;
            case 4:
                result = Divide(num1, num2);
                if (!double.IsNaN(result))
                    Console.WriteLine("Result: {0} / {1} = {2}",num1,num2,result);
                break;
            default:
                Console.WriteLine("Invalid choice! Please select a number between 1 and 4.");
                break;
        }
    }
}
