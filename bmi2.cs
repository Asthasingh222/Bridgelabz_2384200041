using System;

class BMIProgram
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] weight= new double[n];
        double[] height= new double[n];
        double[] bmi=new double[n];
        string[] weightStatus = new string[n];

        // Input weight and height
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter weight (kg) for person {0}: ",i + 1);
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm) for person {0}: ",i + 1);
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate BMI and weight status
        for (int i = 0; i < n; i++)
        {
            bmi[i] = (weight[i] / (height[i] * height[i]))*10000;
            string status;
            if(bmi[i]<=18.4)   status="Underweight";
            else if(bmi[i]>=18.5 && bmi[i]<=24.9) status="Normal";
            else if(bmi[i]>=25.0 && bmi[i]<=39.9) status="Overweight";
            else status="Obese";
            weightStatus[i]=status;
        }

        // Display results
        Console.WriteLine("Height (cm), Weight (kg), BMI, Status: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(height[i]+" , "+weight[i]+" , "+bmi[i]+" , "+weightStatus[i]);
        }
    }
}
