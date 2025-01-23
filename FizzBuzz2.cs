using System;
public class Program {
    public static void Main(string[] args){
        // Prompt user for a number 
        Console.Write("Enter a positive integer : ");
        int num = int.Parse(Console.ReadLine());
        
        int i=0;
        while(i<=num){
             //check if number is multiple of both 3 and  5
            if(i%3==0 && i%5==0)  Console.WriteLine("FizzBuzz");

             //check if number is multiple of 3 
            else if(i%3==0)  Console.WriteLine("Fizz");

            //check if number is multiple of 5
            else if(i%5==0) Console.WriteLine("Buzz");

            else Console.WriteLine(i);
            i++;
        }
    }
}