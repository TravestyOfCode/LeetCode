using LeetCode.Problems1To9.Problem6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Tests.Problems1To9
{
    public class Problem6SolutionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CorrectlyConvertsZigZagPattern(string s, int numRows, string expected)
        {
            // Arrange
            Solution sol = new Solution();

            // Act
            string result = sol.Convert(s, numRows);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { "PAYPALISHIRING", 3, "PAHNAPLSIIGYIR" },
                new object[] { "PAYPALISHIRING", 4, "PINALSIGYAHRPI" },
                new object[] { "A", 1, "A" }
            };
    }
}
