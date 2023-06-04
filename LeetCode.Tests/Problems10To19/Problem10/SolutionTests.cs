﻿using LeetCode.Problems10To19.Problem10;
using Xunit;

namespace LeetCode.Tests.Problems10To19.Problem10
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CorrectlyMatchesStringWithPattern(string s, string p, bool expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            bool result = sol.IsMatch(s, p);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]> 
            {
                new object[] { "aa", "a", false },
                new object[] { "aa", "a*", true },
                new object[] {"ab", ".*", true },
            };
    }
}
