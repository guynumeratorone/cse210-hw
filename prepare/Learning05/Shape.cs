using System;

public class Shape
{
    // Member variable for color
    private string color;

    // Getter and setter for color
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Constructor that accepts color and sets it
    public Shape(string color)
    {
        this.color = color;
    }

    // Virtual method for GetArea()
    public virtual double GetArea()
    {
        // This method will be overridden in derived classes
        return 0;
    }
}
