using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(5.CompareTo(5));
            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            dominoes.Sort();
            /* foreach (var item in dominoes)
             {
                 Console.WriteLine($"{item.GetValues()[0]}, {item.GetValues()[1]}");
             }*/
            var list = new List<Thing>();

            list.Add(new Thing("Get milk"));
            list.Add(new Thing("Remove the obstacles"));
            list.Add(new Thing("Stand up"));
            list.Add(new Thing("Eat lunch"));
            list.Add(new Thing("a"));
            list.Add(new Thing("b"));
            list.Add(new Thing("x"));
            list.Add(new Thing("c"));
            list[2].Complete();
            list[3].Complete();
            list[6].Complete();
            list[0].Complete();
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} {list[i].GetNameAndStatus()}");
            }


        }
    }
}
