using System;
public class Height {
    /*Converting height from cm to feet and inch*/
    public static void Main(string[] args){
        Console.Write("Enter your height in centimeters: ");
        double cm =Convert.ToDouble(Console.ReadLine());//taking input in double
        double heightInches = cm / 2.54;
        int feet = (int)heightInches / 12;
        int inches = (int)heightInches % 12;
        Console.WriteLine("Your Height in cm is "+cm+" while in feet is "+ feet+" and inches is "+ inches);
    }
}