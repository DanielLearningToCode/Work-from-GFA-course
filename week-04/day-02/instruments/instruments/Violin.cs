using System;
using System.Collections.Generic;
using System.Text;

namespace instruments
{
    class Violin : StringedInstruments
    {
        public Violin(int strings)
        {
            numberOfStrings = strings;
        }
        public Violin()
        {
            numberOfStrings = 4;
        }
        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
    }
}
//Violin (4 strings, "Screech")