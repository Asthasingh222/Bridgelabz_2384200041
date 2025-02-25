using System;
using System.IO;

class Program
{
    public static void Main()
    {
        // Define the path of the CSV file
        string path = "file2.csv";

        try
        {
            // Open the file using StreamReader inside a 'using' statement 
            // to ensure proper resource management
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                
                // Read the file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into columns based on commas
                    string[] column = line.Split(',');

                    // Display the extracted data in a formatted way
                    Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Marks: {3}", 
                                      column[0], column[1], column[2], column[3]);
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., file not found, format errors) and display an error message
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
