using System;
using System.IO;

class Program
{
    public static void Main()
    {
        // Define the source file path
        string dstfile = "write.txt";
        try
        {
            // Create a StreamReader to read input from the console
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            {
                Console.Write("Enter Your name: ");
                string name = reader.ReadLine();
                Console.Write("Enter Your age: ");
                string age = reader.ReadLine();
                Console.Write("Enter Your favourite Language: ");
                string lang = reader.ReadLine();

                // Save the information to a file using StreamWriter
                using (StreamWriter writer = new StreamWriter(dstfile))
                {
                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("Age: " + age);
                    writer.WriteLine("Favorite Programming Language: " + lang);
                }

                Console.WriteLine("User Information successfully stored in file.");
            }

        }
        catch (IOException ex)
        {
            // Handle any IO exceptions that may occur during file operations
            Console.WriteLine("An error occurred while handling the file: {0}", ex.Message);
        }
    }
}