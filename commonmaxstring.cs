using System;

class Program{
    public static void Main(string[] args){
        string[] st= {"Sahil","Sagar","Sahmar"};
        string prefix =st[0];
        int cnt=0;
        foreach(string s in st){
             while (!s.StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") break;
            }
        }
        
        Console.WriteLine(prefix);
    }
}