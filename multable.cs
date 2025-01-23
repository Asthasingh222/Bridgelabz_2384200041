using System;

class MultiplicationTable
{
    static void Main()
    {
        // Prompt the user to enter a number to 
        Console.Write("Enter a number to generate its multiplication table (between 6 to 9): ");
        int number = int.Parse(Console.ReadLine());
        
        // Generate and display the multiplication table if the number is between 6 and 9
        if(number>=6 && number<=9){
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number +" * "+ i +" = " + (number * i));
            }
        }
        else{
            Console.WriteLine("Enter a number between 6 and 9");
        }
       
    }
}
