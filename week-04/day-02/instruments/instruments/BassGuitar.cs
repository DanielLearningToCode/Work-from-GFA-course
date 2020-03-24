using System;
using System.Collections.Generic;
using System.Text;

namespace instruments
{
    class BassGuitar : StringedInstruments
    {
        public BassGuitar(int strings)
        {
            numberOfStrings = strings;
        }
        public BassGuitar()
        {
            numberOfStrings = 4;
        }
        public override void Sound()
        {
            Console.WriteLine("Duum-duum-duum");
        }

    }
}
//Bass Guitar (4 strings, "Duum-duum-duum")