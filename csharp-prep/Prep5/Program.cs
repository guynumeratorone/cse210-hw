using System;

class Program
{
    static void Main(string[] args)
    {
        // Statement of welcome
        Console.WriteLine("Welcome to the program!");
        
        // Asks for name
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        
        // Asks user for favorite number
        Console.Write("Please enter your favorite number: ");
        string favoriteNumberInput = Console.ReadLine();

        // Calculate and display the square of the entered favorite number
        if (double.TryParse(favoriteNumberInput, out double favoriteNumber))
        {
            double square = favoriteNumber * favoriteNumber;
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
