using System;
using System.Collections.Generic;

class TwoSum{
    static int[] FindTwoSum(int[] arr,int target){
        Dictionary<int,int> d =new Dictionary<int, int>();
        for(int i=0;i<arr.Length;i++){
            int require = target -arr[i];
            if(d.ContainsKey(require)){
                return new int[] {d[require],i};
            }
            d[arr[i]]=i;
        }
        return new int[] {-1,-1};
    }
    public static void Main(string[] args){
        int[] arr = {10,3,4,1,20,5};
        int[]  res =FindTwoSum(arr,30);
        Console.WriteLine("Indices :[{0},{1}]",res[0],res[1]);
    }
}