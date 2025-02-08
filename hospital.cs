using System;
using System.Collections.Generic;

// Patient class (Can consult multiple doctors)
class Patient
{
    public string Name { get; private set; }

    public Patient(string name)
    {
        Name = name;
    }
}

// Doctor class (Can see multiple patients)
class Doctor
{
    public string Name { get; private set; }
    private List<Patient> patients;

    public Doctor(string name)
    {
        Name = name;
        patients = new List<Patient>();
    }

    public void Consult(Patient patient)
    {
        if (!patients.Contains(patient))
        {
            patients.Add(patient);
        }
        Console.WriteLine("Dr. {0} consulted {1}.",Name,patient.Name);
    }
}

// Hospital class (Contains doctors)
class Hospital
{
    public string Name { get; private set; }
    private List<Doctor> doctors ;

    public Hospital(string name)
    {
        Name = name;
        doctors = new List<Doctor>();
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public void DisplayDoctors()
    {
        Console.WriteLine("Hospital: {0} - Doctors:",Name);
        foreach (var doctor in doctors)
        {
            Console.WriteLine("- Dr. {0}",doctor.Name);
        }
    }
}

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital("City Hospital");

        // Creating doctors
        Doctor doc1 = new Doctor("Emily");
        Doctor doc2 = new Doctor("James");

        // Adding doctors to the hospital
        hospital.AddDoctor(doc1);
        hospital.AddDoctor(doc2);

        // Creating patients
        Patient pat1 = new Patient("Aryan");
        Patient pat2 = new Patient("Megha");

        // Doctors consulting patients
        doc1.Consult(pat1);
        doc1.Consult(pat2);
        doc2.Consult(pat1);

        hospital.DisplayDoctors();
    }
}
