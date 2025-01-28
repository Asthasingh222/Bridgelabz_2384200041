using System;

class Collinearity
{
    // Check collinearity using slopes
    public static bool ArePointsCollinearUsingSlopes(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 -x1);
        return slopeAB == slopeBC && slopeBC ==slopeAC;
    }

    // Check collinearity using triangle area
    public static bool ArePointsCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area==0;
    }

    static void Main()
    {
        Console.WriteLine("Enter points A(x1, y1), B(x2, y2), C(x3, y3):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        bool collinearBySlopes = ArePointsCollinearUsingSlopes(x1, y1, x2, y2, x3, y3);
        bool collinearByArea = ArePointsCollinearUsingArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine("Collinear using slopes: {0}",collinearBySlopes);
        Console.WriteLine("Collinear using area: {0}",collinearByArea);
    }
}
