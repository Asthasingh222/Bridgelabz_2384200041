using System;
public class Program {
    public static void Main(string[] args){

        //prompt to enter number
        Console.Write("Enter a number  : ");
        int num= int.Parse(Console.ReadLine());
        
        //prompt to enter power
        Console.Write("Enter a number  : ");
        int power= int.Parse(Console.ReadLine());
      
        //calculate num^power
        double result=1;
        for(int i=1;i<=power;i++){
            result*=num;
        }
        Console.WriteLine("{0} to the power {1}: {2} ",num,power,result);
    }
}