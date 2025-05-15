using System;

public class Resume
{
    string _name { get; set; }
    List<Job> _jobs { get; set; }

    public Resume(string name)
	{
        name = _name;
        _jobs = new List<Job>();
    }
	public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
