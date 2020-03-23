using System;
using Xunit;

namespace anagram_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var myTest = new AnagramTest();
            bool expected = false;
            bool actual = myTest.IsAnagram("word", "work");
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData ("a gentleman", "elegant man")]
        [InlineData("debit card", "Bad credit")]
        [InlineData("rail safety", "fairy tales")]
        public void Test2(string word1, string word2)
        {
            var myTestObject = new AnagramTest();
            Assert.Equal(true, myTestObject.IsAnagram(word1, word2));
        }
    }
}
