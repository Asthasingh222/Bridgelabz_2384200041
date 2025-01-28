using System;

class Program
{
    //check if the date lies in spring season
    static bool IsSpring(int month, int day)
    {
        if ((month == 3 && day >= 20) || (month == 6 && day <= 20) || (month > 3 && month < 6))
            return true;
        return false;
    }
    static void Main(string[] args)
    {
        //taking month and day as input by command line
        int day = Convert.ToInt32(args[0]);
        int month = Convert.ToInt32(args[1]);

        bool isSpring = IsSpring(month, day);
        if (isSpring)
            Console.WriteLine("It's a Spring Season.");
        else
            Console.WriteLine("Not a Spring Season.");
    }

}
