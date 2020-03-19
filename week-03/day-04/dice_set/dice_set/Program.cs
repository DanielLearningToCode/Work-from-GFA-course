using System;
using System.Collections.Generic;

namespace GreenFoxAcademy
{
    class Program
    {
        public static void Main(string[] argv)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();
            diceSet.Roll();
            // version 1
            /*            bool allSix = false;
                        bool isSix = false;
                        int counter = 0;
                        while (!allSix)
                        {
                            for (int i = 0; i < diceSet.GetCurrent().Length; i++)
                            {
                                if (diceSet.GetCurrent(i) != 6)
                                {
                                    isSix = false;
                                    break;
                                }
                                else
                                {
                                    isSix = true;
                                }   
                            }
                            if (isSix)
                            {
                                allSix = true;
                                break;
                            }
                            counter++;
                            Array.ForEach(diceSet.GetCurrent(), Console.Write);
                            diceSet.Reroll();
                        }
                        if (isSix)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"We needed {counter} trials");
                            Console.WriteLine("All die are six");
                            Array.ForEach(diceSet.GetCurrent(), Console.Write);
                        }*/

            // version 2
            int counter2 = 0;
            for (int dice = 0; dice < diceSet.GetCurrent().Length; dice++)
            {
                while (diceSet.GetCurrent(dice) != 6)
                {
                    diceSet.Reroll(dice);
                    counter2++;
                }
            }
            Array.ForEach(diceSet.GetCurrent(), Console.WriteLine);
            Console.WriteLine(counter2);

        }
    }
}
