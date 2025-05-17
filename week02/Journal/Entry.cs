using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Class to represent a single journal entry
class Entry
{
    // Member variables to store the date, prompt, and user's response
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    // Constructor for the Entry class
    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    // Method to display a single entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}");
        Console.WriteLine();
    }
}