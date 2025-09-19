using System;


class Program
{
    static void Main(string[] args)
    {
        // create fractions using construtors
        fractions fraction1 = new fractions();
        fractions fraction2 = new fractions(5);
        fractions fraction3 = new fractions(3,4);
        fractions fraction4 = new fractions(1,3);
        // displaying fractions
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

    }


}
