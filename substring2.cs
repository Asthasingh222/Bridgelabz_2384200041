using System;

class Program
{
    public static string Substring(string input, int i,int j)
    {
        string res="";
        while(i<=j){
            res+=input[i++];
        }
        return res;
    }

    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.Write("give starting index: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("give ending index: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("By manual method, substring :{0}",Substring(text,a,b));
        Console.WriteLine("By built-in method, substring :{0}",text.Substring(a,b-a+1));
    }
}