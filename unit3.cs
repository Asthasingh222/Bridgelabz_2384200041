using System;
public static class AdvancedUnitConverter
{
    //  Converts Fahrenheit to Celsius. 
    public static double ConvertFahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
    //  Converts Celsius to Fahrenheit. 
    public static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
    //  Converts pounds to kilograms. 
    public static double ConvertPoundsToKilograms(double pounds){
       return  pounds * 0.453592;
    }
    //  Converts kilograms to pounds. 
    public static double ConvertKilogramsToPounds(double kg){
        return kg * 2.20462;
    }
    //  Converts gallons to liters. 
    public static double ConvertGallonsToLiters(double gallons){
        return gallons * 3.78541;
    }
    //  Converts liters to gallons. 
    public static double ConvertLitersToGallons(double liters){
        return liters * 0.264172;
    }

    // Main method to test advanced conversions
    static void Main()
    {
        Console.WriteLine("100°F to Celsius: {0}°C",ConvertFahrenheitToCelsius(100));
        Console.WriteLine("0°C to Fahrenheit: {0}°F",ConvertCelsiusToFahrenheit(0));
        Console.WriteLine("10 pounds to kilograms: {0} kg",ConvertPoundsToKilograms(10));
        Console.WriteLine("5 kg to pounds: {0} lbs",ConvertKilogramsToPounds(5));
        Console.WriteLine("3 gallons to liters: {0} liters",ConvertGallonsToLiters(3));
        Console.WriteLine("10 liters to gallons: {0} gallons",ConvertLitersToGallons(10));
    }

    
}
