using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.Database;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace REST
{
    public class RESTServices
    {
        public static int Sum(int input)
        {
            if (input < 1)
            {
                return 0;
            }
            else if (input == 1)
            {
                return 1;
            }
            else
            {
                return input + Sum(input - 1);
            }
        }
        public static int Factor(int input)
        {
            if (input < 1)
            {
                return 0;
            }
            else if (input == 1)
            {
                return 1;
            }
            else
            {
                return input * Factor(input - 1);
            }
        }

        public ArrayHandler Calculate(ArrayHandler input)
        {
            ArrayHandler result = input;
            if (input.What == "sum")
            {
                result.Result = SumArray(input.Numbers);
            }
            else if (input.What == "multiply")
            {
                result.Result = MultiplyArray(input.Numbers);
            }
            else if (input.What == "doubleAll")
            {
                result.ResultArray = DoubleArray(input.Numbers);
            }
            return result;
        }
        public int SumArray(int[] input)
        {
            /*foreach (int num in input)
            {
                result += num;
            }*/
            return input.Sum();
        }
        public int MultiplyArray(int[] input)
        {
            /*            foreach (int num in input)
                        {
                            result *= num;
                        }
            */
            return input.Aggregate((a, b) => a * b);
        }
        public int[] DoubleArray(int[] input)
        {
            /*int[] result = new int[input.Length];
             for (int i = 0; i < input.Length; i++)
             {
                 result[i] = input[i] * 2;
             }*/
            return input.Select(n => n * 2).ToArray();
        }

        public string Sith(TextForSith input)
        {
            string[] sentences = input.Text.Split('.', StringSplitOptions.RemoveEmptyEntries);
            List<string> yodaTalk = new List<string>();
            List<string> yodaSentences = new List<string>();
            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < words.Length; i++)
                {
                    if (i == 1)
                    {
                        yodaTalk.Add(Capitalize(words[i]));
                        yodaTalk.Add(words[i - 1].ToLower());
                    }
                    else if (i % 2 == 1)
                    {
                        yodaTalk.Add(words[i].ToLower());
                        yodaTalk.Add(words[i - 1].ToLower());
                    }
                }
                if (words.Length % 2 == 1)
                {
                    yodaTalk.Add(words[words.Length - 1].ToLower());
                }
                string yodaSentence = string.Join(" ", yodaTalk) + ".";
                yodaTalk.Clear();
                yodaSentences.Add(yodaSentence);
            }
            string yodaString = string.Join(" ", yodaSentences);
            return yodaString;
        }
        public string Capitalize(string input)
        {
            return string.Concat(char.ToUpper(input[0]), input.Substring(1));
        }
    }
}
