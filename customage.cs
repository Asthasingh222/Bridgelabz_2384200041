using System;

//custom Exception class
class InvalidAgeException :Exception {
    public InvalidAgeException(string s) :base(s){}
}
class Program{

    //throw exception if age<18
    public static void ValidateAge(int a){
        if(a<18)    throw new InvalidAgeException("Age must be 18 or above");
    }
    public static void Main(){
        try{
            Console.Write("Enter Your Age:");
            int age =Convert.ToInt32(Console.ReadLine());
            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch(InvalidAgeException ex){
            Console.WriteLine("Custom Exception: "+ex.Message);
        }
    }
}