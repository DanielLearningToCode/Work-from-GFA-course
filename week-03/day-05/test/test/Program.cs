using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            List <string > words = null;
            try
            {
                text = File.ReadAllText("source.txt");
                words = text.Split(' ').ToList();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message); 
            }

            string result = String.Empty;
            //words.RemoveAll(IsDog);
            words.ForEach(Console.WriteLine);

            //words.RemoveAll(item => item == slovo);  // removing all occurances of a string from a list using 
            // lambda expression

            while (true)
            {
                if (words.Count < 1)
                {
                    break;
                }

                int count = 0;
                string currentWord = words[0];
                for (int i = 0; i < words.Count; i++)
                {
                    if (currentWord == words[i])
                    {
                        count++;
                        
                        words.RemoveAt(i);
                        i--;
                    }
                }
                if (count == 2)
                {
                    result += " " + currentWord;
                }
            }
            Console.WriteLine("Words occuring twice: " + result);
            /*
                        List<string> list = new List<string>() { "pes, kocka, pes, zvire, pes" };
                        Console.WriteLine("pes".Coun);
                        //WordFrequency.SortWords(3);
                        int[,] matrixOne =
                        {
                            {1,2,3,4,5 },
                            {1,2,3,4,8 },
                            {1,2,3,4,5 },
                            {1,2,3,4,8 },
                            {1,2,3,4,5 },
                        };

                        int[,] matrixTwo =
                        {
                            {0,98,3,4,5 },
                            {1,2,4,4,8 },
                            {1,2,3,99,5 },
                            {1,45,3,9,8 },
                            {0,2,6,4,5 },
                        };

                        var result = BiggerMatrix(matrixOne, matrixTwo);
                        for (int i = 0; i < result.GetLength(1); i++)
                        {
                            for (int j = 0; j < result.GetLength(0); j ++)
                            {
                                Console.Write(result[i,j] + ", ");
                            }
                            Console.WriteLine();
                        }

                    }

                    public static int[,] BiggerMatrix(int[,] matrixOne, int[,] matrixTwo)
                    {
                        int[,] outputArray = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
                        for (int row = 0; row < matrixOne.GetLength(0); row++)
                        {
                            for (int column = 0; column < matrixOne.GetLength(1); column++)
                            {
                                //Console.Write(outputArray[row, column]); ;
                                if (matrixOne[row, column] >= matrixTwo[row, column])
                                {
                                    outputArray[row, column] = matrixOne[row, column];
                                }
                                else
                                {
                                    outputArray[row, column] = matrixTwo[row, column];
                                }
                            }
                           // Console.WriteLine();

                        }

                        return outputArray;*/
        }
        public static bool IsDog(string word)
        {
            return word.Equals("pes");
        }


    }
}

