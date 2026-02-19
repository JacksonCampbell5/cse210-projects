public class Swimming : Activity
{
    private double _numOfLaps;
    public Swimming(string date, double minutes, double numOfLaps) : base(date, minutes)
    {
        _numOfLaps = numOfLaps;
    }
    public override double CalculateDistance()
    {
        return _numOfLaps * 50 / 1000;
    }
    public override double CalculateSpeed()
    {
        return CalculateDistance() / _minutes * 60;
    }
    public override double CalculatePace()
    {
        return _minutes / CalculateDistance();
    }
}