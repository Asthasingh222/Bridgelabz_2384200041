using System;

class Program
{
    // calculating various trigonometric functions using Math class
    public static  double[] CalculateTrigonometricFunctions(double angle){
        double angleInRadian = (angle * Math.PI)/180;
        double asin =Math.Sin(angleInRadian);
        double acos =Math.Cos(angleInRadian);
        double atan =Math.Tan(angleInRadian);
        return new double[] {asin,acos,atan};
    }
    static void Main()
    {
        // Taking user input
        Console.Write("Enter the angle in degree: ");
        double a = Convert.ToInt32(Console.ReadLine());


        double r1 = CalculateTrigonometricFunctions(a)[0];
        double r2 = CalculateTrigonometricFunctions(a)[1];
        double r3 = CalculateTrigonometricFunctions(a)[2];

        // Displaying the result
        Console.WriteLine("Sine {0} = {1}",a,r1);
        Console.WriteLine("Cosine {0} = {1}",a,r2);
        Console.WriteLine("Tangent {0} = {1}",a,r3);
    }
}
