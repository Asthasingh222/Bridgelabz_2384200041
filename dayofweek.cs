using System;

class Program
{
    static void Main(string[] args)
    {
        // Check if the correct number of arguments is provided
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: DayOfWeek <month> <day> <year>");
            return;
        }

        // Parse command-line arguments
        int m = int.Parse(args[0]); // Month
        int d = int.Parse(args[1]); // Day
        int y = int.Parse(args[2]); // Year

        // Calculate intermediate values using the formula
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        // Display the day of the week (0 for Sunday, 1 for Monday, etc.)
        Console.WriteLine("The day of the week is: {0}", d0);
    }
}
