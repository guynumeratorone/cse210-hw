using System;
using System.Threading;

public class Breathing
{
    public static void Prompt()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");

        int durationSeconds;
        if (!int.TryParse(Console.ReadLine(), out durationSeconds) || durationSeconds <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for the duration.");
            return;
        }
        Console.Clear();
        Console.WriteLine($"Get ready....");
        Cursor.Animate(durationSeconds);
        int breathInDuration = 4; // Duration for breathing in (in seconds)
        int breathOutDuration = 6; // Duration for breathing out (in seconds)

        int totalCycles = durationSeconds / (breathInDuration + breathOutDuration);

        for (int cycle = 1; cycle <= totalCycles; cycle++)
        {
            
            

            for (int remainingSeconds = durationSeconds; remainingSeconds > 0;)
            {
                if (remainingSeconds <= breathInDuration)
                {
                    for (int i = remainingSeconds; i > 0; i--)
                    {
                        
                        Console.WriteLine($"Breathe in {i}");
                        Thread.Sleep(1000); // Wait for 1 second
                        
                    }
                    remainingSeconds = 0;
                }
                else
                {
                    for (int i = breathInDuration; i > 0; i--)
                    {
                        Console.Clear();
                        Console.WriteLine($"Breathe in {i}");
                        Thread.Sleep(1000); // Wait for 1 second
                    }
                    remainingSeconds -= breathInDuration;
                }

                if (remainingSeconds <= 0) break; // Break if remaining seconds are zero or less

                if (remainingSeconds <= breathOutDuration)
                {
                        
                    for (int i = remainingSeconds; i > 0; i--)
                    {
                        Console.Clear();
                        Console.WriteLine($"Breathe out {i}");
                        Thread.Sleep(1000); // Wait for 1 second
                        Console.Clear();
                    }
                    remainingSeconds = 0;
                }
                else
                {
                    for (int i = breathOutDuration; i > 0; i--)
                    {
                        Console.Clear();
                        Console.WriteLine($"Breathe out {i}");
                        Thread.Sleep(1000); // Wait for 1 second
                        
                    }
                    remainingSeconds -= breathOutDuration;
                }
            }
        }
        Console.Clear();
        Console.WriteLine("Well done!!");
        Cursor.Animate(durationSeconds);
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have have completed another {durationSeconds} seconds of the Breathing Activity.");
        Cursor.Animate(durationSeconds);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}