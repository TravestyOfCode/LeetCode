using LeetCode.Problems1To9.Problem8;
using Xunit;

namespace LeetCode.Tests.Problems1To9.Problem8
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CorrectlyConvertsToInt(string s, int expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            int result = sol.MyAtoi(s);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { "42", 42 },
                new object[] {"-42", -42 },
                new object[] {"4193 with words", 4193 },
                new object[] {"-1123u3761867", -1123},
                new object[] { "   -42", -42},
                new object[] { "words and 987", 0 },
                new object[] { "-91283472332", -2147483648 },
                new object[] { "91283472332", int.MaxValue },
                new object[] { "", 0 },
                new object[] { " ", 0}
            };
    }
}
