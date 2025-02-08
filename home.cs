using System;

// Base class: Device
public class Device
{
    public int DeviceId { get; private set; }
    public string Status { get; private set; }

    public Device(int id, string status)
    {
        DeviceId = id;
        Status = status;
    }

    // Virtual method to allow overriding in the subclass
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: {0}, Status: {1}",DeviceId,Status);
    }
}

// Subclass: Thermostat (inherits from Device)
public class Thermostat : Device
{
    public int TemperatureSetting { get; private set; }

    public Thermostat(int id, string status, int temperature)
        : base(id, status)
    {
        TemperatureSetting = temperature;
    }

    // Overriding DisplayStatus to include temperature setting
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: {0}°C",TemperatureSetting);
    }
}

class Program
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat(1, "On", 22);
        thermostat.DisplayStatus();
    }
}
