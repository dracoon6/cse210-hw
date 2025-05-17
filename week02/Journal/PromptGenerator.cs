using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Class to generate random prompts
class PromptGenerator
{
    // Member variable to store the list of prompts
    private List<string> _prompts;
    private Random _random; //added Random

    // Constructor for the PromptGenerator class
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "What did I learn today?",
            "What made me smile today?",
            "What challenge did I face today?",
            "What act of kindness did I witness or perform today?"
        };
        _random = new Random(); //initialize
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }
        int index = _random.Next(_prompts.Count); //use the random object
        return _prompts[index];
    }
}
