using System;
using System.Collections.Generic;
using System.Text;

namespace instruments
{
    class ElectricGuitar : StringedInstruments
    {
        public ElectricGuitar(int strings)
        {
            numberOfStrings = strings;
        } 
        public ElectricGuitar()
        {
            numberOfStrings = 6;
        }
        public override void Sound()
        {
            Console.WriteLine("Twang");   
        }
    }
}
//Electric Guitar (6 strings, "Twang")