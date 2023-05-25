using LeetCode.Problem2;
using Newtonsoft.Json;
using Xunit;

namespace LeetCode.Tests.Problem2
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CanAddTwoNumbers(int[] array1, int[] array2, int[] expectedArray)
        {
            ListNode l1 = ListNodeFactory.Create(array1);
            ListNode l2 = ListNodeFactory.Create(array2);
            ListNode expected = ListNodeFactory.Create(expectedArray);
            Solution sol = new Solution();

            Assert.Equal(JsonConvert.SerializeObject(expected),
                         JsonConvert.SerializeObject(sol.AddTwoNumbers(l1, l2)));
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 } },
                new object[] { new int[] { 0 }, new int[] { 0 }, new int[] { 0 } },
                new object[] { new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 } }
            };
    }
}
