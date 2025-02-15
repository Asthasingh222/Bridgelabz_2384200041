using System;
using System.Text;
using System.Collections.Generic;
class ConcatenateString{
    static string Concatenate(string[] s){
       StringBuilder sb =new StringBuilder();
        foreach(string ch in s){
            sb.Append(ch);
        }
       
       return sb.ToString();
    }
    static void Main(string[] args){
        string[] sa = {"hello","how","are","you"};
        string res = Concatenate(sa);
        Console.WriteLine("Concatenated string: "+res);
    }
}