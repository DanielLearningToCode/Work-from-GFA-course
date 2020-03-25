using System;
using printable;

namespace Dominoes
{
    public class Domino : IPrintable
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
        public void PrintAllFields()
        {
            Console.WriteLine($"[{values[0]}, {values[1]}]");
        }
    }
}
