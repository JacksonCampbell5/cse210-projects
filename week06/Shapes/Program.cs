using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red",5);
        Rectangle rectangle = new Rectangle("blue",2,3);
        Circle circle = new Circle("yellow",3);
        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetArea());
        Console.WriteLine();
        List<Shape>shapes = new List<Shape>{square,rectangle,circle};
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }

    }
}