using PalindromeExercise;
using System;
using Xunit;



namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("deed", true)]
        [InlineData("noon", true)]
        [InlineData("football", false)]
        [InlineData("shoes", false)]
        [InlineData("name", false)]
        [InlineData("423", false)]
        public void PalidromeTester(string word, bool expected)
        {
            var challenger = new WordSmith();

            var actual = challenger.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }

        //[Theory]
        //[InlineData("racecar", true)]
        //[InlineData("kayak", true)]
        //[InlineData("deed", true)]
        //[InlineData("noon", true)]
        //[InlineData("football", false)]
        //[InlineData("shoes", false)]
        //[InlineData("name", false)]
        //[InlineData("423", false)]
        //public void PalidromeTester(string word, bool expected)
        //{
        //    var challenger = new WordSmith();

        //    var actual = challenger.IsAPalindrome(word);

        //    Assert.Equal(expected, actual);
        //}
    }
}
