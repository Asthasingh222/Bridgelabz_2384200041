using System;
public class Program {
    public static void Main(string[] args){

        //prompt to enter number
        Console.Write("Enter a number  : ");
        int num= int.Parse(Console.ReadLine());
      
        //print all the factors of the number
        Console.WriteLine("All factors of : "+ num);
        for(int i=1;i<num;i++){
            if(num%i==0) Console.WriteLine(i);
        }
        
    }
}