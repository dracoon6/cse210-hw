using System;
using System.Collections.Generic;

class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        if (Minutes == 0) return 0.0;
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        if (_distance == 0) return 0.0;
        return Minutes / _distance;
    }
}
