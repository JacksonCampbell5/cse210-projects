public class Square : Shape
{
    private double _side;
    public Square(string colour, double side)
    {
        _colour = colour;
        _side =side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}