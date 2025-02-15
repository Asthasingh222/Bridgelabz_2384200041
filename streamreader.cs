using System;
using System.IO;
class StreamReaderExample {
    static void Main() {
        string filePath = "sample.txt"; // Ensure the file exists in the project directory

        try {
            using (StreamReader sr = new StreamReader(filePath)) {
                string line;
                while ((line = sr.ReadLine()) != null) { // Read line by line
                    Console.WriteLine(line);
                }
            }
        } catch (IOException e) {
            Console.WriteLine(e.Message);
        }
    }
}
