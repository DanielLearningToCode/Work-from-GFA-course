using System;
using System.Collections.Generic;
using System.Linq;


namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                {"William A. Lathan", "405-709-1865" },
                {"John K. Miller", "402-247-8568"},
                {"Hortensia E. Foster", "606-481-6467" },
                {"Amanda D. Newland","319-243-5613" },
                {"Brooke P. Askew","307-687-2982"}
            };
            FindNumber("John K. Miller", phoneBook);
            FindName("307-687-2982", phoneBook);

        }
        public static void FindNumber(string name, Dictionary <string, string> book)
        {
            bool isInBook = book.TryGetValue(name, out var number);
            if (isInBook)
            {
                Console.WriteLine("{0} has the number: {1}", name, number);
            }
            else
            {
                Console.WriteLine("The name not found in the dictionray");
            }
        }
        public static void FindName(string number, Dictionary <string, string> book)
        {
            var name = "";
            foreach (var item in book)
            {
                if (item.Value == number)
                {
                    name = item.Key;
                }
                
            }
            if (name == "") 
            {
                Console.WriteLine("The number is not in the book");
            }
            else
            {
                Console.WriteLine("The number {0} belongs to {1}",number, name);
            }
        }

    }
}
