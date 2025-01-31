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
    public static string takeinput(){
        //prompt to take input as input
        Console.Write("Enter a text: "); 
        string text = Console.ReadLine(); 
        return text; 
    }
    static void Main(string[] args)  
    {  
        Console.WriteLine("String is Palindrome: {0}",IsPalindrome(takeinput()));
    }  
}
