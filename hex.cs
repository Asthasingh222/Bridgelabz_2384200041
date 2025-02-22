using System;
using System.Text.RegularExpressions;

class HexColorValidator
{
    public bool IsValidHexColor(string color)
    {
        return Regex.IsMatch(color, @"^#([A-Fa-f0-9]{6})$");
    }

    static void Main()
    {
        HexColorValidator validator = new HexColorValidator();
        Console.WriteLine(validator.IsValidHexColor("#FFA500")); // True
        Console.WriteLine(validator.IsValidHexColor("#123"));    // False
    }
}
