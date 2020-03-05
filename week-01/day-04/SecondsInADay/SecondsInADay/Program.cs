using System;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int secondsInaDay = 24 * 3600;
            int remainingSeconds = secondsInaDay - (currentHours * 3600 + currentMinutes * 60 + 42);
            Console.WriteLine(remainingSeconds);
            
            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
        }
    }
}
