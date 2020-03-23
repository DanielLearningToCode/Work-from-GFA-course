using System;
using Xunit;

namespace apple_test
{
    public class Program
    {
        [Fact]
        public static void TestApple()
        {
        Apple myApple = new Apple();
            Assert.Equal("apple", myApple.GetApple());
        }
    }
}
