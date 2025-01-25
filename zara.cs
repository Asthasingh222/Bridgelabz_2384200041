using System;

class BonusCalculator
{
    static void Main()
    {
        const int employeeCount = 10;
        double[] salary = new double[employeeCount];
        double[] yearsOfService = new double[employeeCount];
        double[] bonus = new double[employeeCount];
        double[] newSalary = new double[employeeCount];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        // Input salary and years of service
        for (int i = 0; i < employeeCount; i++)
        {
            Console.Write("Enter salary for employee {0}: ",i + 1);
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years of service for employee {0}: ",i + 1);
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

            // Validate inputs
            if (salary[i] <= 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Try again.");
                i--;
            }
        }

        // Calculate bonus and new salary
        for (int i = 0; i < employeeCount; i++)
        {
            bonus[i] = (yearsOfService[i] > 5) ? salary[i] * 0.05 : salary[i] * 0.02;
            newSalary[i] = salary[i] + bonus[i];
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        // Output results
        Console.WriteLine("Total Bonus Payout: {0}",totalBonus);
        Console.WriteLine("Total Old Salary: {0}",totalOldSalary);
        Console.WriteLine("Total New Salary: {0}",totalNewSalary);
    }
}
