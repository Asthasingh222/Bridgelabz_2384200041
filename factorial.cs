using System;  
class Maximum
{  
    // Method to find the factorial of a number
    public static int FindFactorial(int n)  
    {  
        if(n==1)    return 1;
        return n * FindFactorial(n-1);
    }  
    public static int TakeInput(){
        //prompt to take number as input
        Console.Write("Enter a number: "); 
        int num = Convert.ToInt32(Console.ReadLine()); 
        return num;
    }
    public static void Display(int res,int n){
        Console.WriteLine(res+ "  is the factorial of "+n);
    }
    static void Main(string[] args)  
    {  
        int a=TakeInput();
        int fac=FindFactorial(a);
        Display(fac,a);
    }
}
