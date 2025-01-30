using System;  
class Reverse
{  
    // Method to reverse the string
    public static string ReverseString(string text)  
    {  
        string rev="";
        text.Trim();
        for(int i=text.Length-1;i>=0;i--){
            rev+=text[i];
        }
        return rev;
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter a text: ");  
        string text = Console.ReadLine();  
        string result =ReverseString(text);  
        Console.WriteLine("Original String: {0}",text);
        Console.WriteLine("Reverse String: {0}",result);  
    }  
}
