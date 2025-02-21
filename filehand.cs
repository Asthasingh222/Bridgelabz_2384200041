using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "info.txt";

        try
        {
            // Using 'using' to automatically close the StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine("First line: " + firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
