using System.ComponentModel.DataAnnotations.Schema;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congradulations! You have earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal`{_shortName}`{_description}`{_points}`{_isComplete}";
    }
    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }
}