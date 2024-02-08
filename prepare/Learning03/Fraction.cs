using System;

public class fractions
{
    // making private so that this function only has access to this info
    private int _numerator;
    private int _denominator;

    // constructor
    public fractions()
    {
        _numerator = 1;
        _denominator = 1;

    }

    public fractions(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public fractions(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int top)
    {
        _numerator = top;
    }

    public int GetDenominotor()
    {
        return _denominator;
    }

    public void SetDenominator(int bottom)
    {
        if (bottom != 0)
            _denominator = bottom;
        else
            Console.WriteLine("Denominator cant be zero.");
    }

    public string GetFractionString()
    {
        return _numerator.ToString() + "/" + _denominator.ToString();
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }


 }
