using LeetCode.Problems1To9.Problem7;
using Xunit;

namespace LeetCode.Tests.Problems1To9.Problem7
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CorrectlyReversesInt(int x, int expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            int result = sol.Reverse(x);

            // Arrange
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>()
            {
                new object[] { 123, 321 },
                new object[] {-123, -321 },
                new object[] {120, 21 }
            };

    }
}
