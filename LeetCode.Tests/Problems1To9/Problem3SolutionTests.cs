using LeetCode.Problems1To9.Problem3;
using Xunit;

namespace LeetCode.Tests.Problems1To9
{
    public class Problem3SolutionTests
    {
        [Theory]
        [MemberData(nameof(IntData))]
        public void CorrectlyFindsLengthOfLongestSubstring(string s, int expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            int result = sol.LengthOfLongestSubstring(s);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(StringData))]
        public void CorrectlyFindsStringOfLongestSubstring(string s, string expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            string result = sol.StringOfLongestSubstring(s);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> IntData =>
            new List<object[]>
            {
                new object[] { "abcabcbb", 3 },
                new object[] { "bbbbb", 1 },
                new object[] { "pwwkew", 3 },
                new object[] { "dvdf", 3 },
                new object[] { "aa", 1 },
                new object[] { "abcdefjdhij", 7 }
            };

        public static IEnumerable<object[]> StringData =>
            new List<object[]>
            {
                new object[] { "abcabcbb", "abc" },
                new object[] { "bbbbb", "b" },
                new object[] { "pwwkew", "wke" },
                new object[] { "dvdf", "vdf" },
                new object[] { "aa", "a" },
                new object[] { "abcdefjdhij", "abcdefj" }
            };
    }
}
