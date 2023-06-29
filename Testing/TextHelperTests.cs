using System;
using System.Data;
using Task4;
using Xunit;

namespace Testing
{
    public class TextHelperTests
    {
        [Theory]
        [InlineData("Bus", "suB")]
        public void Should_Return_ReverseString(string inputStr, string exceptedStr)
        {
            var text = TextHelper.ReverseString(inputStr);
            Assert.Equal(exceptedStr, text);

            var pol1 = TextHelper.IsPalindrome("Bus");
            var pol2 = TextHelper.IsPalindrome("suS");
            var pol3 = TextHelper.IsPalindrome("sus");
        }

        [Theory]
        [InlineData("sus")]
        public void Should_Be_Palindrome(string inputStr)
        {
            var isPalindrome = TextHelper.IsPalindrome(inputStr);
            Assert.True(isPalindrome);
        }

        [Theory]
        [InlineData("Bus")]
        [InlineData("suS")]
        public void Should_Not_Be_Palindrome(string inputStr)
        {
            var isPalindrome = TextHelper.IsPalindrome(inputStr);
            Assert.False(isPalindrome);
        }
    }
}
