using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            int totalPointsEarned = _points;

            if (_amountCompleted == _target)
            {
                totalPointsEarned += _bonus;
                Console.WriteLine($"Congratulations! You have completed the Checklist Goal '{_shortName}' and earned a bonus of {_bonus} points!");
            }
            else
            {
                Console.WriteLine($"You have recorded progress for '{_shortName}'. You are {_amountCompleted}/{_target} completed.");
            }
            return totalPointsEarned;
        }
        else
        {
            Console.WriteLine($"The Checklist Goal '{_shortName}' is already fully completed.");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetShortStatusString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public static ChecklistGoal ParseFromString(string data)
    {
        string[] parts = data.Split(',');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        int amountCompleted = int.Parse(parts[3]);
        int target = int.Parse(parts[4]);
        int bonus = int.Parse(parts[5]);
        return new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
    }
}
