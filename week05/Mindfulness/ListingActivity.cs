using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Represents a Listing Activity, inheriting from the base Activity class.
/// This activity prompts the user to list items in a specific positive area.
/// </summary>
public class ListingActivity : Activity
{
    private List<string> _prompts; // List of prompts for listing
    private Random _random; // Random number generator for selecting prompts

    /// <summary>
    /// Constructor for the ListingActivity class.
    /// Initializes the activity name, description, and populates the list of prompts.
    /// </summary>
    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _random = new Random(); // Initialize the random number generator
    }

    /// <summary>
    /// Gets a random prompt from the list of prompts.
    /// </summary>
    /// <returns>A random listing prompt string.</returns>
    private string GetRandomPrompt()
    {
        int index = _random.Next(0, _prompts.Count); // Get a random index
        return _prompts[index]; // Return the prompt at that index
    }

    /// <summary>
    /// Runs the listing activity.
    /// Displays a prompt and then allows the user to list items for the specified duration.
    /// </summary>
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("You will have a few seconds to think about the prompt before you start listing.");
        Console.Write("Starting in: ");
        ShowCountDown(5);
        Console.WriteLine();

        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(">>> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items.");
        DisplayEndingMessage();
    }
}
