using System;
using System.Collections.Generic;

namespace unique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 9, 7, 74, 12, 4, 2, 1, 4, 3, 5, 7 };
            int[] uniqueArray = GetUniqueOnes(array);
            foreach (var num in uniqueArray)
            {
                Console.Write(num + ", ");
            }
        }
        //version 1, using list and array.Contains()

        /*public static int[] GetUniqueOnes(int[] numArray)
        {
            List<int> tempList = new List<int>();
            tempList.Add(numArray[0]);
            for (int i = 0; i < numArray.Length; i++)
            {
                if (!tempList.Contains(numArray[i]))
                {
                    tempList.Add(numArray[i]);
                }
            }
            return tempList.ToArray();
        }*/
        // second version - using basic stuff only, no lists and methods.
        public static int[] GetUniqueOnes(int[] numArray)
        {
            int[] tempArray = new int[numArray.Length];
            int tempArrayIndex = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                int currentNum = numArray[i];
                bool found = false;
                for (int j = i+1; j < numArray.Length; j++)
                {
                    if (currentNum == numArray[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    tempArray[tempArrayIndex] = currentNum;
                    tempArrayIndex++;
                }
            }
            int[] result = new int[tempArrayIndex];
            for (int k = 0; k < result.Length; k++)
            {
                result[k] = tempArray[k];
            }
            return result;
        }
    }
}
////  Create a method that takes an array of integers as a parameter
//  Returns an array of integers where every integer occurs only once
//  Example
//Console.WriteLine(Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
//  should print: `[1, 11, 34, 52, 61]`