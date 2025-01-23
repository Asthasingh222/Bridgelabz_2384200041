using System;
public class Marks {
    public static void Main(string[] args){
        // Prompt user for marks in physics,chemistry and maths. 
        Console.Write("Enter Marks in Physics: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks in Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Marks in Maths: ");
        int maths = int.Parse(Console.ReadLine());

        double avg=(maths+physics+chemistry)/3.0;
        char grade;
        string remark;
        //check average marks to assign grade and remark
        if(avg>=80){
            grade='A';
            remark="Above agency-normalized standards";
        }
        else if(avg>=70 && avg<=79){
            grade='B';
            remark="At agency-normalized standards";
         }
        else if(avg>=60 && avg<=59){
            grade='C';
            remark="Below, but approaching agency-normalized standards";
         }
        else if(avg>=50 && avg<=59){
            grade='D';
            remark="well below agency-normalized standards";
         }
        else if(avg>=40 && avg<=49){
            grade='E';
            remark="too below agency-normalized standards";
         }
        else{
            grade='R';
            remark="Remedial standards";
        }
        //display Avearge marks and grade
        Console.WriteLine("Average mark in PCM :"+ avg+ " and grade Assigned = "+grade+ " ,Remarks: "+remark);
    }
}