using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            while (true)
            {
                Console.Write("Enter text (or type 'exit' to stop): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                writer.WriteLine(input);
            }
        }
        Console.WriteLine("Data written to {0}",filePath);
    }
}
