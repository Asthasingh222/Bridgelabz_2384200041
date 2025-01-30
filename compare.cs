using System;  
class Compare
{  
    // Method to convert case of string
    public static string[] CompareString(string s1,string s2)  
    {  
        int l1=s1.Length;
        int l2=s2.Length;
        int minlen=Math.Min(l1,l2);
        
        for (int i = 0; i < minlen; i++)
        {
            if (s1[i] < s2[i])  return new string[] {s1,s2}; // s1 comes before s2
            if (s1[i] > s2[i])  return new string[] {s2,s1}; // s1 comes after s2
        }

        // If all compared characters are equal, compare string lengths
        if (s1.Length < s2.Length)  return new string[] {s1,s2}; // Shorter string comes first
        else if (s1.Length > s2.Length)  return new string[] {s2,s1}; // Longer string comes later
        else return new string[] {};
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter string 1: ");  
        string st1 = Console.ReadLine();  

        Console.Write("Enter string 2: ");  
        string st2 = Console.ReadLine();  
        string[] result =CompareString(st1,st2);
        Console.WriteLine("{0} comes before {1} in lexicographical order",result[0],result[1]);
    }  
}
