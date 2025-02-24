using System;

class LegacyAPI
{
    // Marking the old method as Obsolete
    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old feature is running...");
    }

    // New recommended method
    public void NewFeature()
    {
        Console.WriteLine("New feature is running...");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();

        // Calling the old method (will show a warning)
        api.OldFeature();

        // Calling the new method (no warning)
        api.NewFeature();
    }
}
