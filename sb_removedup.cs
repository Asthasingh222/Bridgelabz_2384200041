using System;
using System.Text;
using System.Collections.Generic;
class RemoveDuplicate{
    static string DuplicateRemoval(string s){
       StringBuilder sb =new StringBuilder();
       HashSet<char> h = new HashSet<char>();

       foreach(char ch in s){
        if(!h.Contains(ch)){
            h.Add(ch);
            sb.Append(ch);
        }
       }
       
       return sb.ToString();
    }
    static void Main(string[] args){
        Console.Write("Enter a string: ");
        string s =Console.ReadLine();
        string res = DuplicateRemoval(s);
        Console.WriteLine("Reversed string: "+res);
    }
}