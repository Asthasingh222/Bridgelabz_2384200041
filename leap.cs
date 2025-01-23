using System;

class Program
{
    static void Main()
    {
        // Prompt user for year 
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        //check if year>=1582
        if((year>=1582 && year%4==0 && year%100!=0) || (year>=1582 && year%400==0) )
            Console.WriteLine("{0} is a leap year.",year);
        else    Console.WriteLine("{0} is not a leap year.",year);
        
    }
}
