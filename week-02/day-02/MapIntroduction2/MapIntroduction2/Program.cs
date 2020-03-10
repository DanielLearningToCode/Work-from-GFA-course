using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a map where the keys are strings and the values are strings with the following initial values
            Dictionary<string, string> map = new Dictionary<string, string>() 
            { 
                { "978-1-60309-452-8", "A Letter to Jo" },
                {"978-1-60309-459-7","Lupus" },
                {"978-1-60309-444-3", "Red Panda and Moon Bear" },
                {"978-1-60309-461-0","The Lab" }
            };

            // Print all the key-value pairs in the following format
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Value} (ISBN: {item.Key})");
            }

            //Remove the key - value pair with key 978 - 1 - 60309 - 444 - 3
            map.Remove("978-1-60309-444-3");
            Console.WriteLine();
            // Remove the key-value pair with value The Lab
            string searchedKey = "";
            foreach (var item in map)
            {
                if (item.Value == "The Lab")
                {
                    searchedKey = item.Key;
                }
            }
            Console.WriteLine(searchedKey);
            map.Remove(searchedKey);
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Value} (ISBN: {item.Key})");
            }

            // Add the following key-value pairs to the map

            map.Add("978 - 1 - 60309 - 450 - 4", "They Called Us Enemy");
            map.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            // Print whether there is an associated value with key 478-0-61159-424-8 or not

            bool isInDictionary = map.TryGetValue("478-0-61159-424-8", out string value);
            Console.WriteLine($"Found the key 478-0-61159-424-8 : {isInDictionary}");

            Console.WriteLine();

            //Print the value associated with key 978-1-60309-453-5
            isInDictionary = map.TryGetValue("978-1-60309-453-5", out value);
            Console.WriteLine("The key 978 - 1 - 60309 - 453 - 5 has value {0}", value);



        }
    }
}
