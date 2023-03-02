using System;

class Program
{
    static void Main(string[] args)
    {
        Square squareTest = new Square("red", 5);
        // Console.WriteLine(squareTest.GetColor());
        // Console.WriteLine(squareTest.GetArea());

        Rectangle rectangleTest = new Rectangle("blue", 5.5, 10);
        // Console.WriteLine(rectangleTest.GetColor());
        // Console.WriteLine(rectangleTest.GetArea());

        Circle circleTest = new Circle("yellow", 2);
        // Console.WriteLine(circleTest.GetColor());
        // Console.WriteLine(circleTest.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(squareTest);
        shapes.Add(rectangleTest);
        shapes.Add(circleTest);

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}