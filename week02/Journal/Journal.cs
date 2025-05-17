using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Class to manage the collection of journal entries
class Journal
{
    // Member variable to store the list of entries
    private List<Entry> _entries;

    // Constructor for the Journal class
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Method to add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal yet.");
            return;
        }
        Console.WriteLine("--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display(); // Use the Display method of the Entry class
        }
    }

    // Method to save the journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Use a separator that is unlikely to appear in the actual journal entry
                string separator = "~|~";
                foreach (Entry entry in _entries)
                {
                    // Write each entry to a new line in the file, with the parts separated by the separator.
                    outputFile.WriteLine($"{entry.Date}{separator}{entry.PromptText}{separator}{entry.EntryText}");
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving journal to file: {e.Message}");
        }
    }

    // Method to load the journal from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist. Starting with an empty journal.");
                _entries.Clear(); //clear any existing entries
                return; //important to return
            }

            string[] lines = File.ReadAllLines(filename);
            _entries.Clear(); // Clear any existing entries before loading from the file.

            string separator = "~|~";
            foreach (string line in lines)
            {
                string[] parts = line.Split(separator);
                //check if the parts array has the expected number of elements.
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    _entries.Add(new Entry(date, promptText, entryText));
                }
                else
                {
                    Console.WriteLine($"Skipping invalid line: {line}"); //error message
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading journal from file: {e.Message}");
        }
    }
    public int CountEntries()
    {
        return _entries.Count;
    }
}
