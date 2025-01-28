using System;

class BMIProgram
{
    //function to calculate bmi in kg/m^2
    public static double BMI(double weight,double height){
        return ((weight / (height * height))*10000);
    }
    //function to determine BMI status
    static string BmiStatus(double bmi){
            string status;
            if(bmi<=18.4)   status="Underweight";
            else if(bmi>=18.5 && bmi<=24.9) status="Normal";
            else if(bmi>=25.0 && bmi<=39.9) status="Overweight";
            else status="Obese";
            return status;
    }
    static void Main()
    {
        int n = 5;
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
            personData[i, 2] = BMI(personData[i,0],personData[i,1]);
            weightStatus[i] = BmiStatus(personData[i,2]);
        }

        // Display results
        Console.WriteLine("Height (cm), Weight (kg), BMI, Status");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(personData[i,0]+" , "+personData[i,1]+" , "+personData[i,2]+" , "+weightStatus[i]);
        }
    }
}
