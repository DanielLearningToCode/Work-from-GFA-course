using System;
using System.Collections.Generic;
using System.Linq;

namespace MapIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> map = new Dictionary<int, char>();
            
            if (map.Any())
            {
                Console.WriteLine("The map is not empty.");
            }
            else
            {
                Console.WriteLine("The map is empty");
            }
            /*            string myString = @" 
                        97  a
                        98  b
                        99  c
                        65  A
                        66  B
                        67  C";
                        string[] myArray = myString.Split(" ");
            */
            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');

            //Print all the keys
            foreach (var item in map)
            {
                Console.WriteLine(item.Key);
            }
            //Print all the values
            foreach (var item in map)
            {
                Console.WriteLine(item.Value);
            }
            //Add value D with the key 68
            map.Add(68, 'D');
            //Print how many key-value pairs are in the map
            Console.WriteLine(map.Count);
            //Print the value that is associated with key 99
            Console.WriteLine(map[99]);
            //Remove the key-value pair where with key 97
            map.Remove(97);
            Console.WriteLine(map.Count);
            //Print whether there is an associated value with key 100 or not
            bool isValue = map.TryGetValue(100, out char value);
            Console.WriteLine(isValue);
            //Remove all the key-value pairs
            map.Clear();
            if (map.Count != 0)
            {
                Console.WriteLine("The dictionary is not empty");
            }
            else
            {
                Console.WriteLine("The dictionray is empty");
            }
        }

    }
}
