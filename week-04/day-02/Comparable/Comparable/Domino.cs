using System;

namespace Comparable
{
    public class Domino : IComparable <Domino>
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
        public int CompareTo(Domino domino)
        {
            return values[0].CompareTo(domino.values[0]);
        }
    }
}
