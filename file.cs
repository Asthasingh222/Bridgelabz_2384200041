using System;
using System.IO;

class FileStreamExample
{
    static void Main()
    {
        // Define the source file path
        string srcfile = "input.txt";

        try
        {
            // Check if the source file exists
            if (File.Exists(srcfile))
            {
                // Open the source file for reading and create the destination file for writing
                using (FileStream fsRead = new FileStream(srcfile, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream("output.txt", FileMode.Create, FileAccess.Write))
                {
                    int byteData; // Variable to hold the byte read from the source file

                    // Read each byte from the source file until the end of the file is reached
                    while ((byteData = fsRead.ReadByte()) != -1)
                    {
                       
                        fsWrite.WriteByte((byte)byteData);
                    }

                   
                    Console.WriteLine("File copied successfully.");
                }
            }
            else
            {
                // Inform the user that the source file does not exist
                Console.WriteLine("File does not exist!");
                return; 
            }
        }
        catch (IOException ex)
        {
            // Handle any IO exceptions that may occur during file operations
            Console.WriteLine("An error occurred while handling the file: {0}", ex.Message);
        }
    }
}