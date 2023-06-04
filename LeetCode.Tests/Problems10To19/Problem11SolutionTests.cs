using LeetCode.Problems10To19.Problem11;

namespace LeetCode.Tests.Problems10To19;

public class Problem11SolutionTests
{
    [Theory()]
    [MemberData(nameof(Data))]
    public void BruteForceCorrectlyCalculatesMaxArea(int[] height, int expected)
    {
        // Arrange
        BruteForce sol = new BruteForce();

        // Act
        int result = sol.MaxArea(height);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void TwoPointerCorrectlyCalculatesMaxArea(int[] height, int expected)
    {
        // Arrange
        TwoPointer sol = new TwoPointer();

        // Act
        int result = sol.MaxArea(height);

        // Assert
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49 },
            new object[] { new int[] { 1, 1 }, 1 }                
        };
}
