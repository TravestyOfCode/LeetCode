using LeetCode.Problems10To19.Problem14;

namespace LeetCode.Tests.Problems10To19
{
    public class Problem14SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void FirstAttemptCorrectlyFindsLongestCommonPrefix(string[] strs, string expected)
        {
            // Arrange
            FirstAttempt solution = new FirstAttempt();

            // Act
            string result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]{ new string[] { "flower", "flow", "flight" }, "fl" },
                new object[]{ new string[] { "dog", "racecar", "car" }, string.Empty },
                new object[]{ new string[] { }, string.Empty },
                new object[]{ new string[] { "reflower", "flow", "flight" }, string.Empty }
            };
    }
}
