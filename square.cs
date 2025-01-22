using System;
public class Square {
    /*Calculating side of the square from perimeter*/
    public static void Main(string[] args){
        Console.Write("Enter Perimeter of the square : ");
        double per =Convert.ToDouble(Console.ReadLine());//taking input in double
        double side =per /4.0 ; //taking aout side of square
        Console.WriteLine(" The length of the side is "+side+" whose perimeter is "+per);
    }
}