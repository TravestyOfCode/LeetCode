using LeetCode.Problem703;
using Xunit;

namespace LeetCode.Tests.Problem703;

public class PQueueTests
{
    [Fact]
    public void AddReturnsKthIntWithPositiveValues()
    {
        var pQueue = new PQueue(3, new int[] { 4, 5, 8, 2 });

        Assert.Equal(4, pQueue.Add(3));
        Assert.Equal(5, pQueue.Add(5));
        Assert.Equal(5, pQueue.Add(10));
        Assert.Equal(8, pQueue.Add(9));
        Assert.Equal(8, pQueue.Add(4));
    }

    [Fact]
    public void AddReturnsKthIntWithNegativeValues()
    {
        var pQueue = new PQueue(1, new int[] { });

        Assert.Equal(-3, pQueue.Add(-3));
        Assert.Equal(-2, pQueue.Add(-2));
        Assert.Equal(-2, pQueue.Add(-4));
        Assert.Equal(0, pQueue.Add(0));
        Assert.Equal(4, pQueue.Add(4));
    }
}
