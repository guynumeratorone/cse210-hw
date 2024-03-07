using System;

public class Circle : Shape
{
    // Private member variable for radius
    private double _radius;

    // Constructor that accepts color and radius, and calls base constructor with color
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea() method from the base class
    public override double GetArea()
    {
        // Return area of the circle
        return Math.PI * _radius * _radius;
    }
}
