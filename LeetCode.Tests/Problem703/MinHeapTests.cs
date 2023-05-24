using LeetCode.Problem703;
using Xunit;

namespace LeetCode.Tests.Problem703
{
    public class MinHeapTests
    {
        private MinHeap _MinHeap;

        private MinHeap _MinHeapNegative;

        public MinHeapTests()
        {
            _MinHeap = new MinHeap(3, new int[] { 4, 5, 8, 2 });
            _MinHeapNegative = new MinHeap(1, new int[] { });

        }

        [Fact]
        public void GeneratesCorrectResultsWithPositiveNumbers()
        {
            Assert.Equal(4, _MinHeap.Add(3));
            Assert.Equal(5, _MinHeap.Add(5));
            Assert.Equal(5, _MinHeap.Add(10));
            Assert.Equal(8, _MinHeap.Add(9));
            Assert.Equal(8, _MinHeap.Add(4));
        }

        [Fact]
        public void GeneratesCorrectResultsWithNegativeNumbers()
        {
            Assert.Equal(-3, _MinHeapNegative.Add(-3));
            Assert.Equal(-2, _MinHeapNegative.Add(-2));
            Assert.Equal(-2, _MinHeapNegative.Add(-4));
            Assert.Equal(0, _MinHeapNegative.Add(0));
            Assert.Equal(4, _MinHeapNegative.Add(4));
        }
    }
}
