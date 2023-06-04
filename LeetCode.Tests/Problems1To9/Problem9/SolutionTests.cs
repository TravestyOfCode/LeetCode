using LeetCode.Problems1To9.Problem9;
using Xunit;

namespace LeetCode.Tests.Problems1To9.Problem9
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CorrectlyDeterminesPalindrome(int x, bool expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            bool result = sol.IsPalindrome(x);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 121, true },
                new object[] {-121, false },
                new object[] {10, false }
            };
    }
}
