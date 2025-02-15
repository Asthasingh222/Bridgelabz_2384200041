using System;
using System.Text;
using System.IO;

class BytestreamToCharstrem{
    static void Main(string[] args){
        string filePath ="sample2.json";
        try{ 
            // Open the file as a byte stream
            using(FileStream fs =new FileStream(filePath,FileMode.Open,FileAccess.Read)){
                // Convert byte stream into character stream using StreamReader
                using(StreamReader sr =new StreamReader(fs,Encoding.UTF8)){
                    // Read the entire content as characters
                    string content = sr.ReadToEnd();
                    Console.WriteLine("File Content: \n"+ content);
                }
            }
            
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
}