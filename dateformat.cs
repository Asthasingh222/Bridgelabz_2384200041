using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        // Get the current UTC time
        DateTimeOffset date = DateTimeOffset.UtcNow;
        Console.WriteLine("Date in format 1: "+date.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date in format 2: "+date.ToString("yyyy-MM-dd"));
        string formattedDate = date.ToString("ddd,") + date.ToString("MMM dd, yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Date in format 3: " + formattedDate);
    }
}
