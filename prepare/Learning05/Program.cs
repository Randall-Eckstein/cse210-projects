using System;
namespace Learning05;

class Program
{

    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square(6, "blue");
        Rectangle rectangle1 = new Rectangle(4, 6, "yellow");
        Circle circle1 = new Circle(10, "Pink");
        Square square2 = new Square(125, "Orange");
        Rectangle rectangle2 = new Rectangle(1.25, 3.44, "maroon");
        Circle circle2 = new Circle(2.254, "brown");
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        shapes.Add(square2);
        shapes.Add(rectangle2);
        shapes.Add(circle2);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetShape()} is {shape.GetArea()}");
        }
}
}