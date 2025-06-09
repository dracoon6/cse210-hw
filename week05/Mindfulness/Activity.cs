using System;
using System.Threading;
using System.Collections.Generic; 
public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        private set { _description = value; }
    }

    public int Duration
    {
        get { return _duration; }
        protected set { _duration = value; }
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name} Activity!");
        Console.WriteLine();
        Console.WriteLine(Description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive whole number for the duration.");
            Console.Write("How long, in seconds, would you like for your session? ");
            input = Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinnerChars.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i.ToString().PadLeft(2, ' '));
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }

    public abstract void Run();
}
