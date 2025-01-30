using System;  
class Toggle
{  
    // Method to convert case of string
    public static string ToggleCase(string text)  
    {  
         string res = "";
        
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            // Check if the character is lowercase (ASCII: 'a' (97) to 'z' (122))
            if (ch >= 'a' && ch <= 'z')  
                res += (char)(ch - 32); // Convert to uppercase by subtracting 32

            // Check if the character is uppercase (ASCII: 'A' (65) to 'Z' (90))
            else if (ch >= 'A' && ch <= 'Z')  
                res += (char)(ch + 32); // Convert to lowercase by adding 32

            // Keep non-alphabetic characters unchanged
            else res += ch;
        }
        return res;
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter a text: ");  
        string text = Console.ReadLine();   
        Console.WriteLine("String after converting uppercase to lowercase and vice versa: {0}",ToggleCase(text));
    }  
}
