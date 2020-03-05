using System;

namespace Mile_To_Km_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            double miles;
            Console.WriteLine("Please, insert a distance in miles: ");
            miles =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Miles: " + miles + "= Km: " + (miles * 1.609));
            Console.ReadLine();
        }
    }
}
