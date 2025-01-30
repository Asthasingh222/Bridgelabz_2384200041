using System;  
class Palindrome
{  
    // Method to check if string is palindrome
    public static bool IsPalindrome(string text)  
    {  
        string rev="";
        for(int i=text.Length-1;i>=0;i--){
            rev+=text[i];
        }
        return text==rev;
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter a text: ");  
        string text = Console.ReadLine();   
        Console.WriteLine("String is Palindrome: {0}",IsPalindrome(text));
    }  
}
