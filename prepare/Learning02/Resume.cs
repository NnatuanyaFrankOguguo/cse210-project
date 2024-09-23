using System;

public class Resume
{
    public string _name = "";
    public List<Job> _joblists = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine("Jobs :");
        foreach (Job job in _joblists)
        {
            Console.WriteLine($" {job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }
    
}

