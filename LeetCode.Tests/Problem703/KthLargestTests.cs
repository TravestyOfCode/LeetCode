using LeetCode.Problem703;
using Xunit;

namespace LeetCode.Tests.Problem703
{
    public class KthLargestTests
    {
        private KthLargest _KthLargest;

        public KthLargestTests()
        {
            _KthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
        }

        [Fact]
        public void GeneratesCorrectResults()
        {
            Assert.Equal(4, _KthLargest.Add(3));
            Assert.Equal(5, _KthLargest.Add(5));
            Assert.Equal(5, _KthLargest.Add(10));
            Assert.Equal(8, _KthLargest.Add(9));
            Assert.Equal(8, _KthLargest.Add(4));
        }
    }
}
