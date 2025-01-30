using System;  
class Anagram
{  
    // Method to count number of vowels and consonants in the text
    public static bool Anagram(string st1,string st2)  
    {  
        if(st1.Length!=st2.Length)  return false;
        int[] freq = new int[26];

        // Count frequency of each character in string s1
        foreach (char ch in st1)    freq[ch - 'a']++;

        // Count frequency of each character in string s2
        foreach (char ch in st2)    freq[ch - 'a']--;

        // Check if all frequencies are zero
        foreach (int count in freq) {
            if (count != 0)
                return false;
        }
        return true;
        
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter string 1: ");  
        string s1 = Console.ReadLine();  
          
        Console.Write("Enter string 2: ");
        string s2 = Console.ReadLine();
        Console.WriteLine("Strings are anagram of each other: {0}", Anagram(s1,s2));
    }  
}
