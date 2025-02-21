using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data1.txt";

        try
        {
            // Attempt to read the file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:\n" + content);
        }
        catch (IOException)
        {
            // Handle the case where the file does not exist
            Console.WriteLine("File not found");
        }
    }
}
