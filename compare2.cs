using System;  
class Compare
{  
    // Method to convert case of string
    public static bool CompareString(string s1,string s2)  
    {  
        int l1=s1.Length;
        int l2=s2.Length;
        if(l1!=l2)  return false;
        for(int i=0;i<l1;i++){
            if(s1[i]!=s2[i])    return false;
        }
        return true;
    }  
    static void Main(string[] args)  
    {  
        //prompt to take string as input
        Console.Write("Enter string 1: ");  
        string st1 = Console.ReadLine();  

        Console.Write("Enter string 2: ");  
        string st2 = Console.ReadLine();  
        bool flag1=CompareString(st1,st2);
        Console.WriteLine("Result by manual method: "+flag1);

        bool flag2 =st1.Equals(st2);
        Console.WriteLine("Result by built-in method: "+flag2);

        Console.WriteLine("Result by both methods is equal: {0}",flag1==flag2);
    }  
}
