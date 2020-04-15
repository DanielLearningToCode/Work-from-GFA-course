using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lambda_excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Exercise 1
            //Write a LINQ Expression to get the even numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var evenNumbers = n.Where(p => p % 2 == 0);
            //foreach (var num in evenNumbers)
            //{
            //    Console.Write(num + ", ");
            //}

            //Exercise 2
            //Write a LINQ Expression to get the average value of the odd numbers
            //from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var averageOfOddNumbers = n.Where(p => p % 2 != 0).Sum() / n.Where(p => p % 2 != 0).Count();
            //Console.WriteLine(averageOfOddNumbers);

            //Exercise 3
            //Write a LINQ Expression to get the squared value of the positive
            //numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var positiveNumbersSquared = n.Where(p => p > 0).Select(n => n*n);
            //foreach (var num in positiveNumbersSquared)
            //{
            //    Console.WriteLine(num);
            //}

            //Exercise 4
            //Write a LINQ Expression to find which number squared value is more
            //then 20 from the following array:
            //int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            //var numbersSquaredOverTwenty = n.Where(p => p * p > 20);
            //numbersSquaredOverTwenty.ToList().ForEach(Console.WriteLine);

            //Exercise 5
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            //int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //n.GroupBy(p => p).ToDictionary(p => p.Key, p => p.Count()).ToList().ToList().ForEach(p=> { Console.WriteLine(p); });  //.Select(p => new { p.Key, count = p.Count() });

            //KeyValuePair<int, int> pair = new KeyValuePair<int, int>(1, 5);
            //Console.WriteLine(pair);   // WriteLine has overload for printing Key-Value pairs directly


            //foreach (var item in freqList)
            //{
            //    Console.WriteLine(item.Key + " "+ item.Value);    
            //}
            //
            //Exercise 6
            //Write a LINQ Expression to find the frequency of characters in a given string.
            //string testString = "gfdsdfddasds";
            //var freq = testString.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
            //foreach (var character in freq)
            //{
            //    Console.WriteLine(character.Key + " " + character.Value);
            //}

            //Exercise 7
            //Write a LINQ Expression to find the strings which starts with A and 
            //ends with I in the following array:
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", 
            //    "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //cities.Where(c => c.StartsWith('A') && c.EndsWith('I')).ToList().ForEach(Console.WriteLine);

            //Exercise 8
            //Write a LINQ Expression to find the uppercase characters in a string.
            //string text = "ThIs iS a CaMeLCaSe TeXt";
            //var result = text.Where(c => char.IsUpper(c)).ToList();
            //Console.Write(String.Join(' ', result));

            //Exercise 9
            //Write a LINQ Expression to convert a char array to a string.
            //char[] chars = { 'a', 'f', 't', 'G', 'q' };
            //string result = String.Join("", chars);
            //Console.WriteLine(result);

            //Exercise 10
            //Create a Fox class with 3 properties: name, type and color.
            //Fill a list with at least 5 foxes, it's up to you how you name/create them.
            //Write a LINQ Expression to find the foxes with green color.
            //Write a LINQ Expression to find the foxes with green color and pallida type.
            //Fox fox1 = new Fox("one", "common", "red");
            //Fox fox2 = new Fox("two", "vetulus", "green");
            //Fox fox3 = new Fox("three", "vetulus", "grey");
            //Fox fox4 = new Fox("four", "pallida", "red");
            //Fox fox5 = new Fox("five", "pallida", "green");
            //List<Fox> foxList = new List<Fox>();
            //foxList.Add(fox1);
            //foxList.Add(fox2);
            //foxList.Add(fox3);
            //foxList.Add(fox4);
            //foxList.Add(fox5);
            //var greenFoxes = foxList.Where(f => f.Color == "green");
            //Console.WriteLine("green ones: ");
            //foreach (var fox in greenFoxes)
            //{
            //    Console.WriteLine(fox.Name);
            //}
            //Console.WriteLine("Green pallida foxes:");
            //var greenPallidas = foxList.Where(f => f.Color == "green" && f.Type == "pallida");
            //foreach (var fox in greenPallidas)
            //{
            //    Console.WriteLine(fox.Name);
            //}

            //Exercise 11
            //Find a random Wikipedia article and copy the contents to a txt file.
            //Create a single LINQ expression which reads all text from this file, 
            //and prints the 100 most common words in descending order. Keep in mind
            //that the text contains punctuation characters which should be ignored.
            //The result should be something like this:
            //the: 131
            //of: 74
            //and: 48
            //to: 45
            //a: 43
            //in: 43
            //was: 30
            //as: 21
            //German: 18
            //for: 16
            //his: 15
            //by: 13
            //he: 11
            //that: 11
            //char[] charsToRemove = { '\r', '\n', '.', ',',';',':', '?', '!', '(', ')', '\'', '\"', '-', '=','[', ']','0', '1', '2', '3', '4','5', '6', '7', '8', '9' };
            //var result = string.Join("", File.ReadAllText("wikiArticle.txt").Split(charsToRemove)).Split(' ').GroupBy(w => w).OrderByDescending(w => w.Count()).Take(100);
            //var result2 = File.ReadAllText("wikiArticle.txt").ToLower().Split(' ').GroupBy(w => w).OrderByDescending(w => w.Count()).Take(100);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item.Key + ": "+ item.Count());
            //}
        }
    }
}
// jak tisknout: int[] numbers = { 2, 3, 4, 5 };
//var squaredNumbers = numbers.Select(x => x * x);
//Console.WriteLine(string.Join(" ", squaredNumbers));
// Output:
// 4 9 16 25
