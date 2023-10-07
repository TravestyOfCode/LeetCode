using LeetCode.Problems10To19.Problem15;

namespace LeetCode.Tests.Problems10To19;

public class Problem15SolutionTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void FirstAttemptCorrectlyReturnsTriplets(int[] nums, IList<IList<int>> expected)
    {
        // Arrange
        FirstAttempt solution = new FirstAttempt();

        // Act
        var result = solution.ThreeSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { -1, 0, 1, 2, -1, -4 }, new List<IList<int>>()
                        {
                            new List<int>() { -1, -1, 2 },
                            new List<int>() {-1,0,1 }
                        } },
            new object[] { new int[] { 0, 1, 1 }, new List<IList<int>>() { } },
            new object[] { new int[] { 0, 0, 0 }, new List<IList<int>>()
                        {
                            new List<int>() {0,0,0 } }
                        }
        };
}
