using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add instances of Square, Rectangle, and Circle to the list
        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 4, 6));
        shapes.Add(new Circle("green", 3));

        // Iterate through the list of shapes
        foreach (var shape in shapes)
        {
            // Call and display the GetColor() and GetArea() methods for each shape
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine();
        }
    }
}
