public class Running : Activity
{
    private double _distance;
    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return _distance / _minutes * 60;
    }
    public override double CalculatePace()
    {
        return _minutes / _distance;
    }
}