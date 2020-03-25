using Dominoes;
using System;
using System.Collections.Generic;
using FleetOfThings;
namespace printable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domino> dominoList = new List<Domino>()
            {   new Domino(1,2),
                new Domino(5, 2),
                new Domino(4, 6),
                new Domino(1, 5),
                new Domino(6, 7),
                new Domino(2, 4),
                new Domino(7, 1)
            };

            foreach (var stone in dominoList)
            {
                stone.PrintAllFields();
            }

            List<Thing> listOfThings = new List<Thing>();
            listOfThings.Add(new Thing("Get milk"));
            listOfThings.Add(new Thing("Remove the obstacles"));
            listOfThings.Add(new Thing("Stand up"));
            listOfThings.Add(new Thing("Eat lunch"));
            listOfThings[1].Complete();
            listOfThings[3].Complete();

            foreach (var thing in listOfThings)
            {
                thing.PrintAllFields();
            }
        }
    }
}


/*Create a new interface called IPrintable
it should have one method definition called PrintAllFields
implement this interface on the Domino, Todo
*/
