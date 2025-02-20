using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";  // Input file containing text
        string outputFile = "output.txt"; // Output file to store lowercase text

        try
        {
            // Open input file with FileStream for reading
            using (FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedInput = new BufferedStream(inputStream)) // Use BufferedStream for efficiency
            using (StreamReader reader = new StreamReader(bufferedInput, Encoding.UTF8)) // Read text with UTF-8 encoding
            using (FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedOutput = new BufferedStream(outputStream)) // Use BufferedStream for efficiency
            using (StreamWriter writer = new StreamWriter(bufferedOutput, Encoding.UTF8)) // Write text with UTF-8 encoding
            {
                string line;
                while ((line = reader.ReadLine()) != null) // Read each line from input file
                {
                    writer.WriteLine(line.ToLower()); // Convert to lowercase and write to output file
                }
            }

            Console.WriteLine("Conversion completed. Check 'output.txt'.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
