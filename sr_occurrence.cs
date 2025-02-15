using System;
using System.IO;
class StreamReaderOccurrence {
    static void Main() {
        string filePath = "sample.txt"; // Ensure the file exists in the project directory
        string searchWord = "hello";
        int wordCount =0;
        try {
            using (StreamReader sr = new StreamReader(filePath)) {
                string line;
                while ((line = sr.ReadLine()) != null) { // Read line by line
                    // Convert line to lowercase for case-insensitive search
                    string[] words = line.ToLower().Split(' ');
                    
                    foreach (string word in words)
                    {
                        if (word == searchWord.ToLower()) 
                        {
                            wordCount++;
                        }
                    }
                }
            }
            Console.WriteLine("{0} occurred {1} times.",searchWord,wordCount);
        } 
        catch (IOException e) {
            Console.WriteLine(e.Message);
        }
    }
}
