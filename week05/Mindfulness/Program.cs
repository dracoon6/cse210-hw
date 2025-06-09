/*
* Exceeding Requirements:
* * 1. Enhanced Breathing Activity: Instead of a fixed 5-second countdown for "Breathe in..." and "Breathe out...",
* I have used a 4-second "Breathe in..." and a 6-second "Breathe out..." to simulate a more natural and
* pacing breathing cycle, which is often recommended for mindfulness breathing.
* * 2. Clearer Console Experience: I've added `Console.Clear()` calls at the start of `DisplayStartingMessage()`
* and at the end of `DisplayEndingMessage()` in the base `Activity` class, and at the start of the main menu loop
* in `Program.cs`. This ensures a cleaner console output between activities and menu navigations,
* improving the user experience by reducing visual clutter.
* * 3. Robust Duration Input: Implemented basic input validation for the duration input in `DisplayStartingMessage()`
* to ensure the user enters a positive integer. If invalid input is provided, the user is prompted again.
*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    Thread.Sleep(2000);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    Thread.Sleep(2000);
                    continue;
            }

            if (activity != null)
            {
                activity.Run();
            }
        }
    }
}
