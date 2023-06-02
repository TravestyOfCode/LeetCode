using LeetCode.Problem5;
using Xunit;

namespace LeetCode.Tests.Problem5
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CorrectlyFindLongestPalindromicSubstring(string input, string expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            string result = sol.LongestPalindrome(input);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { "babad", "bab" },
                new object[] { "cbbd", "bb" },
                new object[] { "babaddab", "baddab" }
            };
    }
}
