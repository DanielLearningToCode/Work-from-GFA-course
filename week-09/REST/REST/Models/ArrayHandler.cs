using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST
{
    public enum OperationTypes { sum, multiply, doubleAll, none }
    public class ArrayHandler
    {
        public int[] Numbers { get; set; }
        public int[] ResultArray { get; set; }
        public int Result { get; set; }
        public string What { get; set; }
        public ArrayHandler()
        {

        }
    }
}
