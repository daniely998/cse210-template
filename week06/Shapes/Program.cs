using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        Square square = new("Yellow", 4);
        Rectangle rectangle = new("Blue", 3, 4);
        Circle circle = new("Green", 5);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            System.Console.WriteLine(shape.GetColor());
            System.Console.WriteLine($"{shape.GetArea():F2}");
        }
    }
}