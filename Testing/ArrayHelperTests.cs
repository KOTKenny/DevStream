using System;
using System.Data;
using Task4;
using Xunit;

namespace Testing
{
    public class ArrayHelperTests
    {
        [Theory]
        [InlineData(new[] { 4, 6, 9 }, new[] { 5, 7, 8 })]
        [InlineData(new[] { 1, 3, 4 }, new[] { 2 })]
        public void Should_Return_MissingElements(int[] inputArr, int[] exceptedArr)
        {
            var missElems = ArrayHelper.MissingElements(inputArr);
            Assert.Equal(missElems, exceptedArr);
        }

        [Theory]
        [InlineData(new[] { 2, 3, 4 })]
        public void Should_Return_EmptyArray(int[] inputArr)
        {
            var missElems = ArrayHelper.MissingElements(inputArr);
            Assert.Empty(missElems);
        }
    }
}
