using System;

abstract class abc{
       public abstract void m1();
}

class ab:abc{
    public override void m1(){
        System.Console.WriteLine("Hiiiiiii");
      }
    public static void Main(string[] ar)
    {
         ab a=new ab();
         a.m1();
    }
    
}