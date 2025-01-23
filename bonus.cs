using System;

class MultiplicationTable
{
    static void Main()
    {
        // Prompt the user to enter their salary and years of experience
        Console.Write("Enter your Salary : ");
        double salary = int.Parse(Console.ReadLine());
        
        Console.Write("Enter year of experience: ");
        int yoe = int.Parse(Console.ReadLine());
         
         //if year of experience is more than 5 give bonus of 5%
         if(yoe>5){
            double bonus = (5* salary)/100;
            Console.WriteLine("Bonus Amount :"+ bonus);
         }
         else   Console.WriteLine("Bonus not Applicable.");

 
    }
}
