using System;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string filePath = "largefile.txt"; // You would need a large file for this test.

        Console.WriteLine("Testing with file size: 1500 MB");

        // StreamReader
        Stopwatch stopwatch = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1) { } // Read until end of file
        }
        stopwatch.Stop();
        Console.WriteLine("StreamReader Time: " + stopwatch.ElapsedMilliseconds + "ms");

        // FileStream
        stopwatch.Restart();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024];
            // reads 1kb(1024 bytes) at a time from file into buffer 
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        stopwatch.Stop();
        Console.WriteLine("FileStream Time: " + stopwatch.ElapsedMilliseconds + "ms");

        Console.WriteLine();
    
}
}
