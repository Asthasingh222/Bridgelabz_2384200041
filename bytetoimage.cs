using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string originalImagePath = "original.jpeg";  // Replace with actual image file path
        string copiedImagePath = "copied.jpeg";      // Output file name

        try
        {
            // Convert image to byte array using MemoryStream
            byte[] imageBytes = ImageToByteArray(originalImagePath);

            // Convert byte array back to image file using MemoryStream
            ByteArrayToImage(copiedImagePath, imageBytes);

            // Verify if the copied image is identical to the original
            Console.WriteLine(AreFilesIdentical(originalImagePath, copiedImagePath) ? 
                "The copied image is identical to the original." : 
                "The copied image is NOT identical to the original.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }

    // Convert Image File to Byte Array using MemoryStream
    static byte[] ImageToByteArray(string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (MemoryStream memoryStream = new MemoryStream())
        {
            fileStream.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }
    }

    // Convert Byte Array back to Image File using MemoryStream
    static void ByteArrayToImage(string filePath, byte[] byteArray)
    {
        using (MemoryStream memoryStream = new MemoryStream(byteArray))
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            memoryStream.CopyTo(fileStream);
        }
    }

    // Check if Two Files are Identical
    static bool AreFilesIdentical(string file1, string file2)
    {
        return File.ReadAllBytes(file1).SequenceEqual(File.ReadAllBytes(file2));
    }
}
