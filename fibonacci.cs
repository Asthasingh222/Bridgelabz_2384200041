using System;  
class Maximum
{  
    // Method to generate fibonacci series
    public static int[] Fibonacci(int n)  
    {  
        if (n <= 0)
            return new int[0]; // Return an empty array if input is invalid
        
        int[] series = new int[n];
        series[0] = 0;
        if (n > 1)
            series[1] = 1;
        for (int i = 2; i < n; i++)
        {
            series[i] = series[i - 1] + series[i - 2]; // Fibonacci formula
        }

        return series;
        
    }  
    public static int TakeInput(){
        //prompt to take number as input
        Console.Write("Enter a number: "); 
        int num = Convert.ToInt32(Console.ReadLine()); 
        return num;
    }
    public static void Display(int[] res){
        Console.WriteLine("Fibonacci series: ");
        for(int i=0;i<res.Length;i++)   Console.Write(res[i]+"  ");
    }
    static void Main(string[] args)  
    {  
        int a=TakeInput();
        int[] res=Fibonacci(a);
        Display(res);
    }
}
