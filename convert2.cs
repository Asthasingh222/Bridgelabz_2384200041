using System;
public class Volume {
    public static void Main(string[] args){
        Console.Write("Enter distance in kilometers: ");
        double km =Convert.ToDouble(Console.ReadLine());//taking input in double
        double miles=km*0.621371; //converting from km to miles
        Console.WriteLine("The total miles is "+ miles + " mile for the given "+ km);
    }
}