using System;
using System.Collections.Generic;
using System.Text;

namespace instruments
{
    abstract class StringedInstruments : Instrument
    {
        protected int numberOfStrings;
        public override void Play()
        {
            Sound();
        }

        public abstract void Sound();
    }
}
/*Next, we add another abstract class, StringedInstrument which inherit from Instrument.It
    introduces numberOfStrings and
    Sound() method what's implementation is yet unknown
    but with the help of the Sound() the Play() method is fully implementable
*/
