using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running(new DateTime(2023, 11, 03), 30, 3.0);
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling(new DateTime(2023, 11, 04), 45, 15.0);
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming(new DateTime(2023, 11, 05), 60, 20);
        activities.Add(swimmingActivity);

        Running anotherRunningActivity = new Running(new DateTime(2023, 11, 06), 40, 4.5);
        activities.Add(anotherRunningActivity);

        Cycling anotherCyclingActivity = new Cycling(new DateTime(2023, 11, 07), 30, 18.0);
        activities.Add(anotherCyclingActivity);

        Console.WriteLine("--- Exercise Activity Summaries ---");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("---------------------------------");
    }
}