using System;  
class Maximum
{  
    // Method to check if string is palindrome
    public static bool IsPrime(int num)  
    {  
        for(int i=2;i<num;i++){
            if(num%i==0)    return false;
        }
        return true;
    }  
    public static int TakeInput(){
        //prompt to take string as input
        Console.Write("Enter a number: "); 
        int num = Convert.ToInt32(Console.ReadLine()); 
        return num;
    }
    public static void Display(bool res){
        if(res) Console.WriteLine("Number is Prime ");
        else Console.WriteLine("Number is not Prime ");
    }
    static void Main(string[] args)  
    {  
        Display(IsPrime(TakeInput()));
    }
}
