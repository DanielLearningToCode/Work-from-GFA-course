using System;
using System.Collections.Generic;
using System.Linq;

namespace ListInstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty list which will contain names(strings)
            List<string> myList = new List<string>();
            //Print out the number of elements in the list
            Console.WriteLine(myList.Count);
            //Add William to the list
            myList.Add("William");
            //Print out whether the list is empty or not
            if (myList.Any())
            {
                Console.WriteLine("The list is not empty");
            }
            else
            {
                Console.WriteLine("The list is empty");
            }
            //Add John to the list
            myList.Add("John");
            //Add Amanda to the list
            myList.Add("Amanda");
            //Print out the number of elements in the list
            Console.WriteLine(myList.Count);
            //Print out the 3rd element
            Console.WriteLine(myList[2]);
            //Iterate through the list and print out each name
            foreach (var name in myList)
            {
                Console.WriteLine(name);
            }
            // Iterate through the list and print 
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i+1 + "." + myList[i]);
            }            
            //Remove the 2nd element
            myList.RemoveAt(1);

            //Iterate through the list in a reversed order and print out each name
            for (int i = myList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(myList[i]);
            }

            //Remove all elements
            myList.Clear();

        }
    }
}
