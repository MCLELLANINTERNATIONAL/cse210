using System;
using System.Reflection.Metadata.Ecma335;

public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public Resume()
    {
        _jobs = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine("Jobs: ");
        
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}