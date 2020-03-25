using System;
using zoo;

namespace flyable
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter sikorsky = new Helicopter("Sikorsky", 5500, 300);
            Console.WriteLine(sikorsky.CurrentAltitude);
            Console.WriteLine(sikorsky.CurrentSpeed);
            sikorsky.TakeOff();
            sikorsky.Fly(100);
            Console.WriteLine($"The {sikorsky.Make} helicopter.\n Current speed:" +
                $" {sikorsky.CurrentSpeed} km/h \n Altitude: {sikorsky.CurrentAltitude} m");
            sikorsky.Land();
            Console.WriteLine($"The {sikorsky.Make} helicopter.\n Current speed:" +
                $" {sikorsky.CurrentSpeed} km/h \n Altitude: {sikorsky.CurrentAltitude} m");

            Bird blackBird = new Bird("Blackbird");
            blackBird.Fly(10);
            Console.WriteLine($"{blackBird.GetName()} is flying at the speed of {blackBird.GetSpeed()} km/h" +
                $" in the altitude of {blackBird.GetAltitude()} m");
        }
    }
}
