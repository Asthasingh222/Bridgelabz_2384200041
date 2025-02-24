using System;
using System.Reflection;

class Configuration
{
    // Private static field
    private static string API_KEY = "OLD_KEY";

    public static void ShowAPIKey()
    {
        Console.WriteLine("API_KEY: {0}",API_KEY);
    }
}

class Program
{
    static void Main()
    {
        // Show old key
        Configuration.ShowAPIKey();

        // Get the Type
        Type type = typeof(Configuration);

        // Get private field info
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        // Modify the field value
        field.SetValue(null, "NEW_SECRET_KEY");

        // Show updated key
        Configuration.ShowAPIKey();
    }
}
