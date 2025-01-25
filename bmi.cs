using System;

class BMIProgram
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] personData = new double[n, 3];
        string[] weightStatus = new string[n];

        // Input weight and height
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter weight (kg) for person {0}: ",i+1);
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm) for person {0}: ",i+1);
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate BMI and weight status
        for (int i = 0; i < n; i++)
        {
            personData[i, 2] = (personData[i, 0] / (personData[i, 1] * personData[i, 1]))*10000;
            double bmi =personData[i,2];
            string status;
            if(bmi<=18.4)   status="Underweight";
            else if(bmi>=18.5 && bmi<=24.9) status="Normal";
            else if(bmi>=25.0 && bmi<=39.9) status="Overweight";
            else status="Obese";
            weightStatus[i]=status;
        }

        // Display results
        Console.WriteLine("Height (cm), Weight (kg), BMI, Status");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(personData[i,0]+" , "+personData[i,1]+" , "+personData[i,2]+" , "+weightStatus[i]);
        }
    }
}
