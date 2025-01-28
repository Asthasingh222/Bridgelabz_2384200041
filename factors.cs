using System;
using System.Linq;

class Program
{
    // calculating various trigonometric functions using Math class
    public static  int[] CalculateFactors(int n){
        int cnt =0;
        for(int i=1;i<=n;i++){
            if(n%i ==0) cnt++;
        }
        int[] factors =new int[cnt];
        int j=0;
        for(int i=1;i<=n;i++){
            if(n%i==0)  factors[j++]=i;
        }
        return factors;
    }
    public static double CalculateSum(int[] arr){
        double sum=0;
        for(int i=0;i<arr.Length;i++){
            sum+=arr[i];
        }
        return sum;
    }
    public static double CalculateProduct(int[] arr){
        double product=1;
        for(int i=0;i<arr.Length;i++){
            product=arr[i] * product;
        }
        return product;
    }
    public static double CalculateSumOfSquare(int[] arr){
        double square;
        double totalsum=0;
        for(int i=0;i<arr.Length;i++){
            square=Math.Pow(arr[i],2);
            totalsum+=square;
        }
        return totalsum;
    }
    static void Main()
    {
        // Taking user input
        Console.Write("Enter a number : ");
        int a = Convert.ToInt32(Console.ReadLine());

        int[] res =CalculateFactors(a);
        double sum =CalculateSum(res);
        double product =CalculateProduct(res);
        double sumofsqr =CalculateSumOfSquare(res);

        // Displaying the result
        Console.WriteLine("Factors of {0} :",a);
        foreach(int ele in res)
            Console.Write(ele + " , ");
        Console.WriteLine("\nsum of factors = {0}",sum);
        Console.WriteLine("Product of factors = {0}",product);
        Console.WriteLine("Sum of square of factors = {0}",sumofsqr);
    }
}
