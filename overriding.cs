using System;
class Animal{
     // Base class method marked as virtual to allow overriding
    public virtual void MakeSound(){
        Console.WriteLine("Animal makes sound!");
    }
}
class Dog :Animal{
    // Overriding the MakeSound() method
    public override void MakeSound(){
        Console.WriteLine("Dog makes Noise.");
    }
}
class Program{
    public static void Main(){
        Animal d =new Dog();
        d.MakeSound();
    }
}