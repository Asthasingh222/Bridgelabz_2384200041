using System;

public static class UnitConverter
{
     //  Converts kilometers to miles.
    public static double ConvertKmToMiles(double km){
        return   km * 0.621371;
    }
    // Converts miles to kilometers.
    public static double ConvertMilesToKm(double miles){
        return   miles * 1.60934;
    }
    //  Converts meters to feet.
    public static double ConvertMetersToFeet(double meters){
        return   meters * 3.28084;
    }
    //  Converts feet to meters.
    public static double ConvertFeetToMeters(double feet){
        return   feet * 0.3048;
    }
    static void Main()
    {
        Console.WriteLine("10 km to miles: {0} miles",ConvertKmToMiles(10));
        Console.WriteLine("10 miles to km: {0} km",ConvertMilesToKm(10));
        Console.WriteLine("1 meter to feet: {0} feet",ConvertMetersToFeet(1));
        Console.WriteLine("1 foot to meters: {0} meters",ConvertFeetToMeters(1));
    }

   
}
