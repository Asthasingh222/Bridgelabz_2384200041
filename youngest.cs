using System;
public class Program {
    public static void Main(string[] args){

         // Prompt  for Amar's Age and height
        Console.WriteLine("For Amar:");
        Console.Write("Enter Age  : ");
        int age1= int.Parse(Console.ReadLine());
        Console.Write("Enter height in cm : ");
        int  height1= int .Parse(Console.ReadLine());
        
         // Prompt  for Akbar's Age and height
        Console.WriteLine("For Akbar:");
        Console.Write("Enter Age  : ");
        int age2= int.Parse(Console.ReadLine());
        Console.Write("Enter height in cm : ");
        int  height2= int .Parse(Console.ReadLine());

         // Prompt  for Anthony's Age and height
        Console.WriteLine("For Anthony:");
        Console.Write("Enter Age  : ");
        int age3= int.Parse(Console.ReadLine());
        Console.Write("Enter height in cm : ");
        int  height3= int .Parse(Console.ReadLine());

        //check for the youngest 
        if(age1<age2 && age1<age3)  Console.WriteLine("Amar is the youngest with Age: "+ age1);
        if(age2<age1 && age2<age3)  Console.WriteLine("Akbar is the youngest with Age: "+ age2);
        if(age3<age1 && age3<age2)  Console.WriteLine("Anthony is the youngest with Age: "+ age3);
        
        //check for the tallest
        if(height1>height2 && height1>height3)  Console.WriteLine("Amar is the tallest with height: "+ height1);
        if(height2>height1 && height2>height3)  Console.WriteLine("Akbar is the tallest with height: "+ height2);
        if(height3>height1 && height3>height2)  Console.WriteLine("Anthony is the tallest with height: "+ height3);
    }
}