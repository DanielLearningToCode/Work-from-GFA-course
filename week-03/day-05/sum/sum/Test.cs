using System;
using System.Collections.Generic;
using System.Text;

namespace sum
{
    class Test
    {

        public int SumMethod(List<int> listOfInts)
        {
            int sum = 0;
            foreach (var item in listOfInts)
            {
                sum += item;
            }
            return sum;
        }
    }
}
