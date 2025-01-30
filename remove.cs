using System;  
class RemoveChar
{  
    // Method to count number of vowels and consonants in the text
    public static string RemoveCharacter(string text,char ch)  
    {  
        string result="";
        foreach(char s in text){
            if(s==ch)   continue;
            else    result+=s;
        }
        return result;
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter a text: ");  
        string text = Console.ReadLine();  
          
        Console.Write("Enter a character to remove it from the string: ");
        char ch = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("String after removing all occurrences of character {0} : {1}",ch,RemoveCharacter(text,ch));
    }  
}
