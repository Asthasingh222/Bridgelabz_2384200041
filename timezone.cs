using System;

class Program
{
    static void Main()
    {
        // Get the current UTC time
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        Console.WriteLine("UTC Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",utcNow);

        // Convert to GMT (same as UTC)
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcNow, "UTC");
        Console.WriteLine("GMT Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",gmtTime);

        // Convert to IST (Indian Standard Time - UTC+5:30)
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
        Console.WriteLine("IST Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",istTime);

        // Convert to PST (Pacific Standard Time - UTC-8:00)
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
        Console.WriteLine("PST Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",pstTime);
    }
}
