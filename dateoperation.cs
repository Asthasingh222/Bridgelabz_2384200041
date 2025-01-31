using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        try
        {
            // Take a date input from the user
            Console.Write("Enter a date (yyyy-MM-dd): ");
            string input = Console.ReadLine();

            // Ensure the input is in the correct format
            DateTime inputDate;
            bool isValidDate = DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out inputDate);
            
            if (!isValidDate)
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
                return;
            }

            // Add 7 days, 1 month, and 2 years
            DateTime updatedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
            Console.WriteLine("After adding: {0:yyyy-MM-dd}", updatedDate);

            // Subtract 3 weeks (3 * 7 days)
            DateTime finalDate = updatedDate.AddDays(-21);
            Console.WriteLine("After subtracting 3 weeks: {0:yyyy-MM-dd}", finalDate);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }
    }
}
