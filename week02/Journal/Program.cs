using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Program
{
    // Main method - entry point of the program
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filename = "journal.txt"; // Default filename.

        // Load the journal from the file at the start of the program.
        journal.LoadFromFile(filename);

        // Main program loop
        while (true)
        {
            // Display the menu options
            Console.WriteLine("\nJournal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            // Get the user's choice
            string choice = Console.ReadLine();

            // Perform the action based on the user's choice
            switch (choice)
            {
                case "1":
                    // Write a new entry
                    string date = DateTime.Now.ToShortDateString();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nDate: {date}");
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(date, prompt, response));
                    Console.WriteLine("Entry added.");
                    break;
                case "2":
                    // Display the journal
                    journal.DisplayAll();
                    break;
                case "3":
                    // Save the journal to a file
                    Console.Write("Enter the filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "4":
                    // Load the journal from a file
                    Console.Write("Enter the filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    // Exit the program
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}