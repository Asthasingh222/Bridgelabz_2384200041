using System;

class Program
{
    //function to check whether a number positive,negative or zero
     static int Check(int num)
    {
       if(num>0)    return 1;
       else if(num<0)    return -1;
       else return 0;
    }
    static void Main(string[] args)
    {
        //prompt to input a number
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int res =Check(num);
        Console.WriteLine("Result: "+res);
    }


}
