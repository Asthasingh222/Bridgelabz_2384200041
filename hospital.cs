using System;

class Patient
{
    // Static Variable (Shared among all instances)
    private static string hospitalName = "City Hospital";
    private static int totalPatients = 0;

    // Readonly Variable (Unique for each patient)
    private readonly int patientID;
    
    // Instance Variables
    private string name;
    private int age;
    private string ailment;

    // Getter Methods for Encapsulation
    public static string GetHospitalName()
    {
        return hospitalName;
    }

    public int GetPatientID()
    {
        return patientID;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetAilment()
    {
        return ailment;
    }

    // Constructor using 'this' keyword
    public Patient(int patientID, string name, int age, string ailment)
    {
        this.patientID = patientID;
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        totalPatients++;
    }

    // Static Method to Get Total Patients
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    // Method to Display Patient Details
    public void DisplayDetails()
    {
        Console.WriteLine("Hospital Name: " + GetHospitalName());
        Console.WriteLine("Patient ID: " + GetPatientID() + ", Name: " + GetName() + ", Age: " + GetAge() + ", Ailment: " + GetAilment());
    }
}

// Main Program
static class Program
{
    static void Main()
    {
        // Creating Patient Objects
        Patient p1 = new Patient(101, "Rohan Prakash", 45, "Fever");
        Patient p2 = new Patient(102, "Prerna Kashyap", 30, "Cold");

        // Using 'is' operator before displaying details
        if (p1 is Patient) p1.DisplayDetails();
        if (p2 is Patient) p2.DisplayDetails();

        // Displaying total patients admitted
        Patient.GetTotalPatients();
    }
}
