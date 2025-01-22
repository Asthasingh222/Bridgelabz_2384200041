using System;
public class Calculator {
    /*A basic calculator to perform addition,subtraction,multiplication and division*/
    public static void Main(string[] args){
        Console.Write("Enter first Number: ");
        float a =Single.Parse(Console.ReadLine());//taking input in float
        Console.Write("Enter Second Number: ");
        float b =Single.Parse(Console.ReadLine());//taking input in float
        float sum = a+b; 
        float sub = a-b;
        float mult =a*b;
        float div =a/b;
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+a+" and "+b+ " is " +sum+ " , "+sub+ " , "+mult + " , "+ div );
    }
}