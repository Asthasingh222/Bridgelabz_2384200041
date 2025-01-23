using System;
public class Program {
    public static void Main(string[] args){

        //prompt to enter number
        Console.Write("Enter a number  : ");
        int num= int.Parse(Console.ReadLine());
      
        //print all the multiples of the number
        Console.WriteLine("All multiples of : "+ num);
        for(int i=num;i>=1;i--){
            if(num%i==0) Console.WriteLine(i);
        }
        
    }
}