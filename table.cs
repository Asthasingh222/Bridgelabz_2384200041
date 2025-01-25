using System;

class MultiplicationTableRange
{
    static void Main()
    {
        Console.WriteLine("Enter a number to generate its multiplication table from 6 to 9:");
        int number = int.Parse(Console.ReadLine());
        int[] table =new int[10];

        // Loop through the range 0 to 10
        for (int i = 0; i < 10; i++)
        {
           table[i]=number *(i+1);
        }

        //display table from array
         for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}",number,i+1,table[i]);
        }
    }
}
