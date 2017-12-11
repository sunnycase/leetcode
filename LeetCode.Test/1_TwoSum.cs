using System;
using Xunit;

namespace LeetCode.Test
{
    public class TwoSumTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(new[] { 0, 1 }, new Solution().TwoSum_Naive(new[] { 2, 7, 11, 15 }, 9));
            Assert.Equal(new[] { 0, 1 }, new Solution().TwoSum(new[] { 2, 7, 11, 15 }, 9));
        }
    }
}
