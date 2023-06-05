using LeetCode.Problems10To19.Problem13;

namespace LeetCode.Tests.Problems10To19
{
    public class Problem13SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void FirstAttemptCorrectlyConvertsToInt(string s, int expected)
        {
            // Arrange
            FirstAttempt solution = new FirstAttempt();

            // Act
            int result = solution.RomanToInt(s);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void SecondAttemptCorrectlyConvertsToInt(string s, int expected)
        {
            // Arrange
            SecondAttempt solution = new SecondAttempt();

            // Act
            int result = solution.RomanToInt(s);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { "III", 3 },
                new object[] { "LVIII", 58 },
                new object[] { "MCMXCIV", 1994 }
            };
    }
}
