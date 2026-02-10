public abstract class Shape
{
    protected string _colour;
    public string GetColour()
    {
        return _colour;
    }
    public void SetColour(string colour)
    {
        _colour = colour;
    }
    public abstract double GetArea();
}