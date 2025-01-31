using System;

class ConvertTemp{
    static double CelsiusToFahrenheit(double temp){
        // Conversion formula from fahrenheit to Celsius
        double celsius = (temp - 32) * 5 / 9;
        return celsius;
    }
    static double FahrenheitToCelsius(double temp){
        double fahrenheit = (temp * 9 / 5) + 32;
        return fahrenheit;
    }
    public static double TakeInput(){
        //prompt to enter a number
        Console.Write("Enter temperature: "); 
        double num = Convert.ToDouble(Console.ReadLine()); 
        return num;
    }
    public static void Display(double res){
        Console.WriteLine("After Conversion: "+res);
    }
    static void Main(string[] args){
    Console.WriteLine("From Celsius to Fahrenheit: ");
    double ans1 =CelsiusToFahrenheit(TakeInput());
    Display(ans1);

    Console.WriteLine("From Fahrenheit to Celsius: ");
    double ans2 =FahrenheitToCelsius(TakeInput());
    Display(ans2);
    }
}