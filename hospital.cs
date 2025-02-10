using System;
using System.Collections.Generic;

// Abstract class representing a patient
abstract class Patient
{
    private string patientId;
    private string name;
    private int age;
    protected double billAmount; // Protected to allow subclasses to modify

    // Constructor
    public Patient(string id, string name, int age)
    {
        this.patientId = id;
        this.name = name;
        this.age = age;
        this.billAmount = 0;
    }

    // Encapsulation: Getter methods for private fields
    public string GetPatientId() { return patientId; }
    public string GetName() { return name; }
    public int GetAge() { return age; }

    // Method to display patient details
    public void GetPatientDetails()
    {
        Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", patientId, name, age);
    }

    // Abstract method for calculating bills (to be overridden in subclasses)
    public abstract double CalculateBill();
}

// Interface for medical records
interface IMedicalRecord
{
    void AddRecord(string diagnosis);
    void ViewRecords();
}

// InPatient class with additional charges
class InPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords = new List<string>();
    private double dailyCharge;
    private int daysAdmitted;

    public InPatient(string id, string name, int age, double dailyCharge, int days)
        : base(id, name, age)
    {
        this.dailyCharge = dailyCharge;
        this.daysAdmitted = days;
    }

    // Overriding CalculateBill for in-patients
    public override double CalculateBill()
    {
        billAmount = daysAdmitted * dailyCharge;
        return billAmount;
    }

    // Adding a medical record
    public void AddRecord(string diagnosis)
    {
        medicalRecords.Add(diagnosis);
    }

    // Viewing all medical records
    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// OutPatient class with consultation fees
class OutPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords = new List<string>();
    private double consultationFee;

    public OutPatient(string id, string name, int age, double consultationFee)
        : base(id, name, age)
    {
        this.consultationFee = consultationFee;
    }

    // Overriding CalculateBill for out-patients
    public override double CalculateBill()
    {
        billAmount = consultationFee;
        return billAmount;
    }

    // Adding a medical record
    public void AddRecord(string diagnosis)
    {
        medicalRecords.Add(diagnosis);
    }

    // Viewing all medical records
    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// Main class to demonstrate polymorphism
class Program
{
    static void Main()
    {
        // List to store different types of patients
        List<Patient> patients = new List<Patient>();

        // Creating patients
        InPatient inPatient = new InPatient("P101", "Amaya", 30, 1000, 5);
        OutPatient outPatient = new OutPatient("P202", "Bhoomika", 25, 500);

        // Adding patients to the list
        patients.Add(inPatient);
        patients.Add(outPatient);

        // Processing each patient
        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine("Total Bill: $" + patient.CalculateBill());

            // Checking if the patient has medical records
            if (patient is IMedicalRecord)
            {
                IMedicalRecord record = (IMedicalRecord)patient;
                record.AddRecord("Initial Diagnosis: Fever");
                record.AddRecord("Routine Checkup");
                record.ViewRecords();
            }
            Console.WriteLine("--------------------------");
        }
    }
}
