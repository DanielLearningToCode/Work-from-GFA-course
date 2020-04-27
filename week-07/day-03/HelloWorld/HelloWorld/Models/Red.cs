using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Red : IColor
    { 
        public void PrintColor()
        {
            Console.WriteLine("It is red in color...");
        }
    }
}
