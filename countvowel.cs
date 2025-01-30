using System;  
class Vowels
{  
    // Method to count number of vowels and consonants in the text
    public static int[] CountVowelsAndConsonants(string text)  
    {  
        int vowelcnt=0,consonantcnt=0;
        foreach(char s in text){
            if(s=='a'|| s=='e'||s=='i'||s=='o'||s=='u'||s=='A'||s=='E'||s=='I'||s=='O'||s=='U')
            vowelcnt++;
            else if((s>='A' &&  s<='Z') || (s>='a' &&  s<='z'))
            consonantcnt++;
        }
        return new int[] {vowelcnt,consonantcnt};
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter a text: ");  
        string text = Console.ReadLine();  
        int[] result =CountVowelsAndConsonants(text);  
        Console.WriteLine("Number of Vowels: {0}",result[0]);
        Console.WriteLine("Number of Consonants: {0}",result[1]);  
    }  
}
