using System;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

class Program
{
    static void ReadLargeCSV(string filename)
    {
        int batchSize = 100; // Process 100 records at a time
        int count = 0; // Total records processed

        try
        {
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                while (csv.Read()) // Read each row one by one
                {
                    count++;

                    // Display progress every 100 records
                    if (count % batchSize == 0)
                    {
                        Console.WriteLine($"Processed {count} records...");
                    }
                }
            }

            Console.WriteLine($"Total records processed: {count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading CSV: {ex.Message}");
        }
    }

    static void Main()
    {
        ReadLargeCSV("largefile.csv"); // Specify the large CSV file
    }
}
