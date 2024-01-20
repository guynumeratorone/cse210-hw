using System;

class Program
{
    static void Main(string[] args)
    {
        //asks for first name
        Console.WriteLine("What is your first name?");
        string userFirstName = Console.ReadLine();

        //asks for last name
        Console.WriteLine("What is your last name?");
        string userLastName = Console.ReadLine();


        //displays both names
        Console.WriteLine($"Your name is {userLastName}, {userFirstName} {userLastName}");
    }
}
