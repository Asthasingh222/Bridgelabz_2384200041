using System;

class LeapYearChecker
{
    // Determines if a year is a leap year.
    static bool IsLeapYear(int year)
    {
        // Leap year conditions
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
    static void Main()
    {
        // Prompt user to enter a year
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());
        if (year > 1582)
        {
            // Check if the year is a leap year
            bool isLeap = IsLeapYear(year);
            // Display the result
            Console.WriteLine("{0} is {1}a leap year.",year,isLeap ? "" : "not ");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a year >= 1582.");
        }
    }
    
}
