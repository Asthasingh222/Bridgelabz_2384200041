using System;
public class Triangle {
    /*Calculating area of the traingle*/
    public static void Main(string[] args){
        Console.Write("Enter base of the triangle in cm: ");
        double b =Convert.ToDouble(Console.ReadLine());//taking input in float
        Console.Write("Enter height of the triangle in cm: ");
        double height =Convert.ToDouble(Console.ReadLine());//taking input in float
        double area1= 0.5 * b * height; //area of traingle
        double area2 =area1 *0.155; //conerting area into square inches
        Console.WriteLine("Area of triangle with height "+height +" cm and base "+b +" cm is "+area1 +" square cm or "+area2+" square inches" );
    }
}