using System;
using System.Reflection;

class MathOperations
{

    public void Add(int a,int b)// Public addition method
    {
        Console.WriteLine("Addition: "+(a+b));
     }  
    
    public void Subtract(int a,int b)// Public method
    {
        Console.WriteLine("Subtraction: "+(a-b));
     }  
     
    public void Multiply(int a,int b)// Public method
    {
        Console.WriteLine("Multiplication: "+(a*b));
     }  
      
}

class Program
{
    static void Main()
    {
         //  Get user input for the method name
        Console.Write("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        //  Get user input for numbers
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        //  Get the Type of MathOperations class
        Type type = typeof(MathOperations);

        //  Create an instance of MathOperations using Reflection
        object instance = Activator.CreateInstance(type);

        //  Get MethodInfo for the user-specified method
        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            //  Invoke the method dynamically
            method.Invoke(instance, new object[] { num1, num2 });
        }
        else
        {
            Console.WriteLine("Invalid method name.");
        }
    }
}
