using System;
using System.Reflection;

class Calculator
{
    private void Multiply(int a,int b){// Private method
        Console.WriteLine("Multiplication Result: "+a*b);
    } 
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);

        // Get private method 'Multiply'
        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (method != null)
        {
            //invoke Multiply method
            method.Invoke(calculator,new object[]{5,6});
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}