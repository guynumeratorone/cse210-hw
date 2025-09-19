using System;

public class Rectangle : Shape
{
    // Private member variables for width and height
    private double _width;
    private double _height;

    // Constructor that accepts color, width, and height, and calls base constructor with color
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    // Override GetArea() method from the base class
    public override double GetArea()
    {
        // Return area of the rectangle
        return _width * _height;
    }
}
