using System;
using System.Collections.Generic;

class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int Minutes
    {
        get { return _minutes; }
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");

        string activityType = GetType().Name;

        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);

        return $"{formattedDate} {activityType} ({_minutes} min) - Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
    }
}
