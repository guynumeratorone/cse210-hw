using System;

public class Square : Shape
{
    // Private member variable for side
    private double _side;

    // Constructor that accepts color and side, and calls base constructor with color
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea() method from the base class
    public override double GetArea()
    {
        // Return area of the square
        return _side * _side;
    }
}
