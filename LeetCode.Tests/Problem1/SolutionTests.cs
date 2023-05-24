using LeetCode.Problem1;
using Xunit;

namespace LeetCode.Tests.Problem1
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[]{2,7,11,15}, 9, new int[] { 1, 0 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 2, 1 })]
        [InlineData(new int[] { 3,3 }, 6, new int[] { 1, 0 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new int[] { 11, 5 })]
        public void FindsCorrectIndexs(int[] values, int target, int[] expected)
        {
            Solution solution = new Solution();

            Assert.Equal(expected, solution.TwoSum(values, target));
        }
    }
}
