using System;
using System.Text;
class ReverseString{
    static string Reverse(string s){
       StringBuilder sb =new StringBuilder(s);
       int i=0,j=sb.Length-1;

       while(i<j){
        char temp = sb[i];
        sb[i]=sb[j];
        sb[j] =temp;
        i++;j--;
       }
       return sb.ToString();
    }
    static void Main(string[] args){
        Console.Write("Enter a string: ");
        string s =Console.ReadLine();
        string rev = Reverse(s);
        Console.WriteLine("Reversed string: "+rev);
    }
}