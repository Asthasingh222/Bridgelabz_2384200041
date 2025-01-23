using System;
public class BMI {
    public static void Main(string[] args){
        // Prompt user for weight
        Console.Write("Enter Weight in kg : ");
        double weight= double.Parse(Console.ReadLine());
       
        // Prompt user for height
        Console.Write("Enter height in cm : ");
        int  height= int .Parse(Console.ReadLine());


        //convert height from cm to m
        double heightInm= height*0.01;


        //formula to calculate BMI
        double bmi =weight/(heightInm*heightInm);
       
        //check conditions for BMI status
        string status;
        if(bmi<=18.4)   status="Underweight";
        else if(bmi>=18.5 && bmi<=24.9) status="Normal";
        else if(bmi>=25.0 && bmi<=39.9) status="Overweight";
        else status="Obese";


        //display bmi status
        Console.WriteLine("BMI : "+bmi +" , Status : "+status);
    }
}
