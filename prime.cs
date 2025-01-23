using System;
public class Program {
    public static void Main(string[] args){
        // Prompt user for a number to check if prime
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        if(num<=1){
            Console.WriteLine("Invalid input! Enter a number greater than 1");
            return;
        }
        bool isPrime =true;

        //Loop through all the numbers from 2 to number and check if the remainder is zero
        for(int i=2;i<num;i++){
            if(num%i==0) {
                isPrime=false;
                break;
            }
        }
        
        //display result
        Console.WriteLine(num+ " is Prime : "+isPrime);
    }
}