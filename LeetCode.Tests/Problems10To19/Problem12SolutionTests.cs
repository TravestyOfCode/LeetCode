using LeetCode.Problems10To19.Problem12;

namespace LeetCode.Tests.Problems10To19
{
    public class Problem12SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void FirstAttemptCorrectlyConvertsToRoman(int num, string expected)
        {
            // Arrange
            FirstAttempt solution = new FirstAttempt();

            // Act
            string result = solution.IntToRoman(num);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]{ 3, "III" },
                new object[]{58, "LVIII"},
                new object[]{1994, "MCMXCIV"}
            };
    }
}
