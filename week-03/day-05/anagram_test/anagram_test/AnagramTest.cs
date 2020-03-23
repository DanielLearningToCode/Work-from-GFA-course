using System;
using System.Collections.Generic;
using System.Text;

namespace anagram_test
{
    class AnagramTest
    {
        public bool IsAnagram(string firstWord, string secondWord)
        {
            firstWord = firstWord.ToLower().Trim();
            secondWord = secondWord.ToLower().Trim();
            if (firstWord.Length == secondWord.Length && firstWord.Length > 0)
            {
                foreach (var letter in firstWord)
                {
                    if (!secondWord.Contains(letter))
                    {
                        return false;
                    }
                    else   // test in the opposite direction
                    {
                        foreach (var secondWordLetter in secondWord)
                        {
                            if (!firstWord.Contains(secondWordLetter))
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
