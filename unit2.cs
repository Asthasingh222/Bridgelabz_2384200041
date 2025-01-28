using System;

public static class UnitConverter
{
    
    // Converts Inches to centimeters
    public static double ConvertInchesToCm(double inches){
        return   inches * 2.54;
    }
    //  Converts inches to meters
    public static double ConvertInchesToMeters(double inches){
        return   inches * 0.0254;
    }
    //  Converts meters to Inches
    public static double ConvertMetersToInches(double meters){
        return   meters * 39.3701;
    }
    //  Converts yards to feet. 
    public static double ConvertYardsToFeet(double yards){ 
        return yards * 3;
    }
    //  Converts feet to yards. 
    public static double ConvertFeetToYards(double feet){ 
        return feet * 0.333333;
    }
    static void Main()
    {
        Console.WriteLine("10 inches to cm: {0} km",ConvertInchesToCm(10));
        Console.WriteLine("20 inches to meters: {0} feet",ConvertInchesToMeters(20));
        Console.WriteLine("10 meters to inches: {0} meters",ConvertMetersToInches(10));
        Console.WriteLine("5 yards to feet: {0} feet",ConvertYardsToFeet(5));
        Console.WriteLine("15 feet to yards: {0} yards",ConvertFeetToYards(15));
    }

   
}
