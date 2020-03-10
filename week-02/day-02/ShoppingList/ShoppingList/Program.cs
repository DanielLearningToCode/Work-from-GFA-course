using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = new List<string>() { "Eggs", "milk", "fish", "apples", "bread", "chicken" };
            IsInList("bananas ", shoppingList);
        }
        public static void IsInList (string searchedItem, List<string> shoppingList)
        {
            int counter = 0;
            foreach (var item in shoppingList)
            {
                if (item.ToLower().Trim() == searchedItem.ToLower().Trim())
                {
                    Console.WriteLine("The {0} is in the list",searchedItem);
                    counter = 0;
                    break;
                }
                counter++;
            }

            if (counter != 0)
            {
                Console.WriteLine("The {0} is not in the list", searchedItem);
            }
        }
    }
}
