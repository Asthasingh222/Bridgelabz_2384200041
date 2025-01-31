using System;
class MaximumPrime{
    public static void Main(string[] args){
        int[] arr =new int[5];
        for(int i=0;i<5;i++){
            Console.Write("Enter element {0} in array: ",i+1);
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        int maxprime =0;
        for(int i=0;i<arr.Length;i++){
            int elem= arr[i];
            bool flag=true;
            for(int j=2;j<elem ;j++){
                if(elem%j==0){
                    flag=false;
                    break;
                }
            }
            if(flag)    maxprime=Math.Max(elem,maxprime);
        }
        Console.WriteLine("Maximum prime number: "+maxprime);

    }
}