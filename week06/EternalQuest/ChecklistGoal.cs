public class ChecklistGoal : Goal
{
    int _ammountCompleted = 0;
    int _target;
    int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _ammountCompleted += 1;
        if (IsComplete())
        {
            Console.WriteLine($"Congradulations! You have earned {_points + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congradulations! You have earned {_points} points!");
        }
    }
    public override bool IsComplete()
    {
        if (_ammountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string complete;
            if (IsComplete())
            {
                complete = "X"; 
            }
            else
            {
                complete = " ";
            }
        return $"[{complete}] {_shortName} ({_description}) -- Currently Completed: {_ammountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal`{_shortName}`{_description}`{_points}`{_target}`{_points}`{_ammountCompleted}";
    }
    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
        
    }
    public void SetAmmountCompleted(int ammount)
    {
        _ammountCompleted = ammount;
    }
}