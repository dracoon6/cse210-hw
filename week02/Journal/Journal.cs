using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

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
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                string separator = "~|~";
                foreach (Entry entry in _entries)
                {
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

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist. Starting with an empty journal.");
                _entries.Clear();
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();

            string separator = "~|~";
            foreach (string line in lines)
            {
                string[] parts = line.Split(separator);
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    _entries.Add(new Entry(date, promptText, entryText));
                }
                else
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
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
