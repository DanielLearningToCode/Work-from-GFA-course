using System;
using System.Collections.Generic;
using Xunit;

namespace sum
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var myTest = new Test();
            List<int> listOfInts = new List<int>() { 5, 9, 7, 1, 2 };
            int expected = 24;
            int actual = myTest.SumMethod(listOfInts);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            var myTest = new Test();
            List<int> listOfInts=null;
            Assert.Throws<NullReferenceException>(() => myTest.SumMethod(listOfInts));
        }

        [Fact]
        public void Test3()
        {
            var myTest = new Test();
            List<int> listOfInts = new List<int>() { };
            var actual = myTest.SumMethod(listOfInts);
            Assert.Equal(0, actual);
        }
        [Fact]
        public void Test4()
        {
            var myTest = new Test();
            List<int> listOfInt = new List<int>() { 5 };
            var actual = myTest.SumMethod(listOfInt);
            Assert.Equal(5, actual);
        }
  /*      Create different tests where you test your method with:

    an empyt list
    a list that has one element in it
    a list that has multiple elements in it
    a null*/
    }
}

