using System;
class Propogationex
{
    static void Method1(){
        int b=0;
        int res =10/b;
    }
    static void Method2(){
        Method1();
    }
    static void Main(string[] args)
    {
        try
        {
            Method2();
        }
        //handle dividebyzero exception
        catch (DivideByZeroException )
        {
            Console.WriteLine("Hnadled exception in Main");
        }
    }
}
