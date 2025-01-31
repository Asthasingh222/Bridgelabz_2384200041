using System;
class MatrixProduct{
    public static void Main(string[] args){
        int[, ] mat =new int[3,3];
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                Console.Write("Enter element [{0},{1}] :",i,j);
                mat[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Entered matrix: ");
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                Console.Write(mat[i,j]+"    ");
            }
            Console.WriteLine();
        }
        double product=1;
        
         for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                if(i==j)    product*=mat[i,j];
            }
        }
        Console.Write("Product: "+ product);

    }
}