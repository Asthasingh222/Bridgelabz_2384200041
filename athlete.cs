using System;
public class Triangle {
    /*Calculating area of the traingle*/
    public static void Main(string[] args){
        //taking length of the sides of traingle as input
        Console.Write("Enter length of side 1 of traingle meter: ");
        double a =Convert.ToDouble(Console.ReadLine());//taking input in float
        
        Console.Write("Enter length of side 2 of traingle meter: ");
        double b =Convert.ToDouble(Console.ReadLine());//taking input in float

        Console.Write("Enter length of side 3 of traingle meter: ");
        double c =Convert.ToDouble(Console.ReadLine());//taking input in float
        
        //calculating perimeter of traingle
        double perimeter =a+b+c; 
        
        //calculating number of rounds in 5km(5000 m)
        int rounds=(int)(5000/perimeter);
        Console.WriteLine("The total number of rounds the athlete will run is {0} to complete 5 km",rounds );
    }
}