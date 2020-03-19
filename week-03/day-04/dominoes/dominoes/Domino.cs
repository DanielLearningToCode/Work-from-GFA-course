using System;

namespace Domino
{
    public class Domino
    {
        private readonly int[] values;

        public Domino(int valueA, int valueB)
        {
            this.values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return values;
        }
    }
}
