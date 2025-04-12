using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Circle("Green", 3.5),
            new Rectangle("Yellow", 10, 2),
            new Square("Purple", 7)
        };

        Console.WriteLine("Shape Areas:");
        Console.WriteLine("============");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} (Color: {shape.Color}) → Area: {shape.GetArea():F2}");
        }
    }
}
