using System;
using System.IO;
using System.Diagnostics;

class BufferedStreamExample
{
    static void CopyFileWithBufferedStream(string src, string dst)
    {
        using (FileStream fs = new FileStream(src, FileMode.Open, FileAccess.Read))
        using (BufferedStream bs = new BufferedStream(fs))
        using (FileStream fsOut = new FileStream(dst, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096]; // 4 KB buffer
            int bytesRead;

            // Read from the buffered stream and write to the destination file
            while ((bytesRead = bs.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsOut.Write(buffer, 0, bytesRead);
            }
        }
        Console.WriteLine("File copied successfully with buffering.");
    }
    
    static void CopyFileWithFileStream(string src, string dst)
    {
        using (FileStream fs = new FileStream(src, FileMode.Open, FileAccess.Read))
        using (FileStream fsOut = new FileStream(dst, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096]; // 4 KB buffer
            int bytesRead;

            // Read from the file stream and write to the destination file
            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsOut.Write(buffer, 0, bytesRead);
            }
        }
        Console.WriteLine("File copied successfully without buffering.");
    }

    static void Main()
    {
        string srcfile = "file2.txt"; // Source file path
        string bufferdespath = "outputbuf.txt"; // Destination for buffered copy
        string unbufferedpath = "outputunb.txt"; // Destination for unbuffered copy

        try
        {
            if (!File.Exists(srcfile))
            {
                Console.WriteLine("File does not exist!");
                return;
            }

            // Measure time for buffered copy
            Stopwatch stp = new Stopwatch();
            stp.Start();
            CopyFileWithBufferedStream(srcfile, bufferdespath);
            stp.Stop();
            Console.WriteLine("Buffered copy time: {0} ms", stp.ElapsedMilliseconds);

            // Measure time for unbuffered copy
            stp.Restart();
            CopyFileWithFileStream(srcfile, unbufferedpath);
            stp.Stop();
            Console.WriteLine("UnBuffered copy time: {0} ms", stp.ElapsedMilliseconds);
        }
        catch (IOException ex)
        {
            // Handle any IO exceptions that may occur during file operations
            Console.WriteLine("An error occurred while handling the file: {0}", ex.Message);
        }
    }
}