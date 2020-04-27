using HelloWorld.Interfaces;
using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Printer
    {
        IColor color;
        public Printer(IColor color)
        {
            this.color = color; 
        }
        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);

            if (color is Red)
            {
            Console.WriteLine("The color is red from the printer method");
            }
            else
            {
                Console.WriteLine("The color is blue from the printer method");
            }
        }
    }
}
