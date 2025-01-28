using System;
using System.Linq;

class OTPGenerator
{
    // Generate a 6-digit OTP
    public static string GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000).ToString();
    }

    // Validate unique OTPs
    public static bool ValidateUniqueOTPs(string[] otps)
    {
        return otps.Distinct().Count() == otps.Length;
    }

    static void Main()
    {
        string[] otps = new string[10];
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP {0}: {1}",i + 1,otps[i]);
        }

        Console.WriteLine("Are all OTPs unique? {0}",ValidateUniqueOTPs(otps));
    }
}
