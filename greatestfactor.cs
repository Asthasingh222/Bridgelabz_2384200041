using System;
public class Program {
    public static void Main(string[] args){

        //prompt to enter a number
        Console.Write("Enter a number  : ");
        int num= int.Parse(Console.ReadLine());

        int greatestFactor =1;

        //check if the number is perfectly divisible by i then assign i to greatestFactor variable
        for(int i=num-1;i>=1;i--){
            if(num%i==0){
                greatestFactor=i;
                break;
            }
        }
        Console.WriteLine("Greatest factor of {0} : {1}",num,greatestFactor);
    }
}