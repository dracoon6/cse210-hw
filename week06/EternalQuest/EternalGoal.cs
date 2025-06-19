using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public EternalGoal(string name, string description, int points, int amountCompleted) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {base.GetDetailsString()} (Eternal Goal)";
    }

    public override string GetShortStatusString()
    {
        return $"[ ] {_shortName}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

    public static EternalGoal ParseFromString(string data)
    {
        string[] parts = data.Split(',');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        return new EternalGoal(name, description, points);
    }
}
