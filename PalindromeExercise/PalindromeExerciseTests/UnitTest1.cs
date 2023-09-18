using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("tacocat", true)]
        [InlineData("meatball", false)]
        [InlineData("radar", true)]
        [InlineData("level", true)]
        public void IsAPalindromeTest(string str1, bool expected)
        {
            WordSmith instance = new WordSmith();

            bool actual = instance.IsAPalindrome(str1);

            Assert.Equal(expected, actual);
        }
    }
}
