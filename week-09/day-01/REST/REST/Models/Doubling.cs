using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class Doubling
    {
        public int? Received { get; set; }
        public int Result { get; set; }
        public Doubling()
        {

        }
        public Doubling(int? input)
        {
            Received = input;
            Result = (int)input * 2;
        }

    }
}
