using System;  
class Maximum
{  
    // Method to find the maximum of three numbers.
    public static int FindMaximum(int n1,int n2,int n3)  
    {  
        return Math.Max(n1,Math.Max(n2,n3));
    }  
    public static int TakeInput(){
       //prompt to take number as input
        Console.Write("Enter a number: "); 
        int num = Convert.ToInt32(Console.ReadLine()); 
        return num;
    }
    public static void Display(int res){
        Console.WriteLine(res+ "  is Maximum ");
    }
    static void Main(string[] args)  
    {  
        Console.WriteLine("Enter three numbers: ");
        int a=TakeInput();
        int b=TakeInput();
        int c=TakeInput();
        int maxi=FindMaximum(a,b,c);
        Display(maxi);
    }
}
