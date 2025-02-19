using System;
using System.Collections.Generic;

// Abstract class representing a job role
public abstract class JobRole
{
    public string CandidateName { get; set; }
    public int Experience { get; set; } // In years
    public List<string> Skills { get; set; }
    
    public abstract bool IsEligible();
}

// Concrete class for Software Engineer role
public class SoftwareEngineer : JobRole
{
    public override bool IsEligible()
    {
        return Experience >= 2 && Skills.Contains("C#");
    }
}

// Concrete class for Data Scientist role
public class DataScientist : JobRole
{
    public override bool IsEligible()
    {
        return Experience >= 3 && Skills.Contains("Python") && Skills.Contains("Machine Learning");
    }
}

// Generic class for handling resumes
public class Resume<T> where T : JobRole
{
    public T Candidate { get; set; }

    public Resume(T candidate)
    {
        Candidate = candidate;
    }

    public void ProcessResume()
    {
        Console.WriteLine("Processing resume of " + Candidate.CandidateName + " for " + typeof(T).Name);
        if (Candidate.IsEligible())
        {
            Console.WriteLine("Candidate is eligible for the role.");
        }
        else
        {
            Console.WriteLine("Candidate is not eligible for the role.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating and processing a Software Engineer resume
        SoftwareEngineer seCandidate = new SoftwareEngineer
        {
            CandidateName = "Aryan",
            Experience = 3,
            Skills = new List<string> { "C#", "SQL", "ASP.NET" }
        };
        Resume<SoftwareEngineer> seResume = new Resume<SoftwareEngineer>(seCandidate);
        seResume.ProcessResume();

        // Creating and processing a Data Scientist resume
        DataScientist dsCandidate = new DataScientist
        {
            CandidateName = "Bhavna",
            Experience = 2,
            Skills = new List<string> { "Python", "Data Analysis" }
        };
        Resume<DataScientist> dsResume = new Resume<DataScientist>(dsCandidate);
        dsResume.ProcessResume();
    }
}
