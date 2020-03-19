using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] [5, 2] [2,4]...
            //  [1,5][5,2][2,4][4,6][6,7][7,1]  ???
            // Console.WriteLine(dominoes[1].GetValues()[1]);

            Console.WriteLine(SortDominoes(dominoes));

            //Console.WriteLine(GetFirstOne(dominoes).GetValues()[0]);


            foreach (var item in SortDominoes(dominoes))
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.GetValues()[1]);
            }

        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
        public static Domino GetFirstOne(List<Domino> dominoes)
        {
            Domino firstOne = null;
            for (int i = 0; i < dominoes.Count; i++)
            {
                if (dominoes[i].GetValues()[0] == 1)
                {
                    firstOne = dominoes[i];
                }
            }
            return firstOne;
        }
        public static List<Domino> SortDominoes(List<Domino> dominoes)
        {
            var sortedList = new List<Domino>();
            sortedList.Add(GetFirstOne(dominoes));
            while (sortedList.Count < dominoes.Count)
            {
                for (int i = 0; i < dominoes.Count; i++)
                {
                    if (dominoes[i].GetValues()[0] == sortedList[sortedList.Count - 1].GetValues()[1])
                    {
                        sortedList.Add(dominoes[i]);
                    }
                }

            }

            return sortedList;
        }
    }
}
