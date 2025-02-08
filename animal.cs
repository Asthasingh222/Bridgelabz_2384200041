using System;
// Base class (Superclass)
class Animal{
    public string name{get; private set;}
    public int age{get; private set;}
    protected Animal(string name ,int age){
        this.name = name;
        this.age = age;
    }
     // Virtual method to be overridden
    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal{
    public Dog(string name ,int age): base(name,age){}
    public override void MakeSound(){
        Console.WriteLine("Dog Barks");
    }
}
class Cat : Animal{
    public Cat(string name ,int age) : base(name,age){}
    public override void MakeSound(){
        Console.WriteLine("Cat meows");
    }
}
class Bird : Animal{
    public Bird(string name ,int age) : base(name,age){}
    public override void MakeSound(){
        Console.WriteLine("Bird chirps");
    }
}
class Program{
    public static void Main(string[] args){
        // Creating objects of subclasses
        Animal mydog =new Dog("Dyna",3);
        Animal mycat =new Cat("kitty",2);
        Animal mybird =new Bird("Tweety", 1);

         // Demonstrating polymorphism: Each overridden method is called based on the actual object type
        mydog.MakeSound(); 
        mycat.MakeSound(); 
        mybird.MakeSound();
    }
}