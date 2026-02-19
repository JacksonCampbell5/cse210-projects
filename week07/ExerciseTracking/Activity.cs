public abstract class Activity
{
    private string _date;
    protected double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min)- Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }

}