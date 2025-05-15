using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.Name = "Microsoft";
        job1.Title = "Software Engineer";
        job1.StartYear = 2020;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.Name = "Apple";
        job2.Title = "Manager";
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        Resume myResume = new Resume("Allison Rose");

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.Display();
    }
}