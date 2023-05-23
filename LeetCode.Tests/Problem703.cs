using LeetCode.Problem703;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem703
    {
        private KthLargest KthLargest;
        
        public Problem703()
        {
            KthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
        }

        [Fact]
        public void GeneratesCorrectResults()
        {
            Assert.Equal(4, KthLargest.Add(3));
            Assert.Equal(5, KthLargest.Add(5));
            Assert.Equal(5, KthLargest.Add(10));
            Assert.Equal(8, KthLargest.Add(9));
            Assert.Equal(8, KthLargest.Add(4));
        }
    }
}
