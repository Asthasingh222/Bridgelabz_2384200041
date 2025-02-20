using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "file2.txt";  // Large file to process

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null) // Read file line by line
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);  // Print lines containing "error"
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
