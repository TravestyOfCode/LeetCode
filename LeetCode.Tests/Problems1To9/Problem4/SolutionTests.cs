using LeetCode.Problems1To9.Problem4;
using Xunit;

namespace LeetCode.Tests.Problems1To9.Problem4
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CorrectlyFindMedianSortedArray(int[] nums1, int[] nums2, double expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            double result = sol.FindMedianSortedArrays(nums1, nums2);

            // Assert
            Assert.Equal(expected, result);

        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]{ new int[] {1, 3 }, new int[] { 2 }, 2.0 },
                new object[]{ new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5 }

            };
    }
}
