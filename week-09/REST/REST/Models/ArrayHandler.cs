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
        /*public ArrayHandler(int[] inputArray, string operation)
        {
            Numbers = inputArray;
            switch (operation)
            {
                case "sum":
                    {
                        What = OperationTypes.sum;
                        break;
                    }
                case "multiply":
                    {
                        What = OperationTypes.multiply;
                        break;
                    }
                case "double":
                    {
                        What = OperationTypes.doubleAll;
                        break;
                    }
                default:
                    {
                        What = OperationTypes.none;
                        break;
                    }
            }
        }*/
    }
}
