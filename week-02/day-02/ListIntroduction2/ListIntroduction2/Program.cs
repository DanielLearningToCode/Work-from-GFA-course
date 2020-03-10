using System;
using System.Collections.Generic;

namespace ListIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List_A = new List<string>() { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            
            //Create a new list ('List B') with the values of List A
            List<string> List_B = new List<string>(List_A);

            //Print out whether List A contains Durian or not
            if (List_A.Contains("Durian"))
            {
                Console.WriteLine("The list A contains Durian");
            }
            else
            {
                Console.WriteLine("The list A does not contain Durian");
            }
            // Remove Durian from List B
            List_B.Remove("Durian");
            if (List_B.Contains("Durian"))
            {
                Console.WriteLine("The list B contains Durian");
            }
            else
            {
                Console.WriteLine("The list B does not contain Durian");
            }
            // Add Kiwifruit to List A after the 4th element
            List_A.Insert(4, "Kiwifruit");
            foreach (var item in List_A)
            {
                Console.WriteLine(item);
            }
            // Compare the size of List A and List B
            if (List_A.Count > List_B.Count)
            {
                Console.WriteLine("The list A is bigger");
            }
            else
            {
                Console.WriteLine("The list B is bigger");
            }
            // Get the index of Avocado from List A
            int occurance = List_A.IndexOf("Avocado");
            Console.WriteLine("The index of Avocado in the list A is: " + occurance);

            //Get the index of Durian from List B
            Console.WriteLine("The index of durian in the list B is: "
                + List_B.IndexOf("Durian") + " meaning it is not in the list");

            // Add Passion Fruit and Pomelo to List B in a single statement
            string[] fruit = { "Passion Fruit", "Pomelo" };
            List_B.AddRange(fruit);
            foreach (var item in List_B)
            {
                Console.WriteLine(item);
            }
            // Print out the 3rd element from List A
            Console.WriteLine(List_A[2]);
        }
    }
}
