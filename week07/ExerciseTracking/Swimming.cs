using System;
using System.Collections.Generic;

class Swimming : Activity
{
    private int _laps;
    private const double LAP_LENGTH_METERS = 50;
    private const double METERS_TO_MILES = 0.000621371;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceInMeters = _laps * LAP_LENGTH_METERS;
        return distanceInMeters * METERS_TO_MILES;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        if (Minutes == 0) return 0.0;
        return (distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0) return 0.0;
        return Minutes / distance;
    }
}
