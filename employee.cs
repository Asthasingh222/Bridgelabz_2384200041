using System;
 
 // Base class (Superclass)
 class Employee{
    public string name{get; private set;}
    public int id {get; private set;}
    public double salary {get; private set;}
    protected Employee(string name,int id,double salary){
        this.name=name;
        this.id= id;
        this.salary =salary;
    }
     // Virtual method to be overridden
    public virtual void DisplayDetails(){
        Console.WriteLine("Name : "+name);
        Console.WriteLine("ID : "+id);
        Console.WriteLine("Salary : "+salary);
    }
 }
 class Manager : Employee{
    public int teamSize{get; private set;}
    public Manager(string name,int id,double salary, int team) :base(name,id,salary){
        teamSize =team;
    }
    public override  void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Team Size : "+teamSize);
    }
 }
 class Developer : Employee{
    public string programmingLanguage {get; private set;}
    public Developer(string name,int id,double salary, string plang) :base(name,id,salary){
        programmingLanguage =plang;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Programming Language : "+programmingLanguage);
    }
 }
 class Intern : Employee{
    public string internshipDuration{get; private set;}
    public Intern(string name,int id,double salary, string duration) :base(name,id,salary){
        internshipDuration =duration;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Internship Duration : "+internshipDuration);
    }
 }
 class Program{
    public static void Main(string[] args){
        // Creating objects for each employee type
        Employee emp1= new Manager("Aryan",101,1200000,10);
        Employee emp2 =new Developer("Astha",13,450000,"C++");
        Employee emp3 = new Intern("Kartik",42,300000,"6 months");

        // Display details using polymorphism
        emp1.DisplayDetails();
        emp2.DisplayDetails();
        emp3.DisplayDetails();
    }
 }