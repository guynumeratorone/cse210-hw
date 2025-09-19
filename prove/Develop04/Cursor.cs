using System;
using System.Threading;

public class Cursor
{
    public static void Animate(int durationSeconds)
    {
        int breathInDuration = 4; // Duration for breathing in (in seconds)
        int breathOutDuration = 6; // Duration for breathing out (in seconds)

        int totalCycles = durationSeconds / (breathInDuration + breathOutDuration);

       
        
        for (int i = 0; i < totalCycles * 1; i++)
        {
            Console.Write("-\r"); // Display '-'
            Thread.Sleep(600); // Wait for half a second

            Console.Write("/\r"); // Display '/'
            Thread.Sleep(600); // Wait for half a second

            Console.Write("-\r"); // Display '-'
            Thread.Sleep(600); // Wait for half a second

            Console.Write("\\\r"); // Display '\'
            Thread.Sleep(600); // Wait for half a second
        }

        
    }
}
