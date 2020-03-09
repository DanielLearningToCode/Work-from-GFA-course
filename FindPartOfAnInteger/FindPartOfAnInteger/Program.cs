using System;

namespace FindPartOfAnInteger
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:
            //Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'



            // does not work correctly for 0 as the searched for number. 
            int[] numbers = new int[] { 1, 11, 34, 52, 61, 360, 50, 101 };
            int searchedForNumber = 1;

            string indices = SubInt(searchedForNumber, numbers);
            Console.WriteLine(indices);
        }
        public static string SubInt(int number, int[] array)
        {
            string indices = "";
            if (number == 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if(array[i] == number || array[i] % 10 == 0 || array[i] % 100 == 0 || (array[i] / 10) % 10 == 0) 
                    { 
                    
                        indices += i.ToString() + ", ";
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == number || array[i] / 10 == number || array[i] % 10 == number
                         || array[i] / 100 == number || array[i] % 100 == number || (array[i] / 10) % 10 == number)
                    {
                        indices += i.ToString() + ", ";
                    }
                }
            }
            
            return indices; 
        }


    }
}
