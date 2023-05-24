using Xunit;

namespace LeetCode.Tests.Problem703
{
    public class MinIntHeapTests
    {

        [Fact]
        public void AddReturnsCorrectKthWithPositiveNumbers()
        {
            var _queue = new KthLargest(3, new int[] { 4, 5, 8, 2 });

            Assert.Equal(4, _queue.Add(3));
            Assert.Equal(5, _queue.Add(5));
            Assert.Equal(5, _queue.Add(10));
            Assert.Equal(8, _queue.Add(9));
            Assert.Equal(8, _queue.Add(4));
        }

        [Fact]
        public void AddReturnsCorrectKthWithNegativeNumbers()
        {
            var _queueNeg = new KthLargest(1, new int[] { });

            Assert.Equal(-3, _queueNeg.Add(-3));
            Assert.Equal(-2, _queueNeg.Add(-2));
            Assert.Equal(-2, _queueNeg.Add(-4));
            Assert.Equal(0, _queueNeg.Add(0));
            Assert.Equal(4, _queueNeg.Add(4));
        }
    }
}
