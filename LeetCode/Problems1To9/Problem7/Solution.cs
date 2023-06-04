using System;
using System.Text;

namespace LeetCode.Problems1To9.Problem7
{
    public class Solution
    {
        public int Reverse(int x)
        {
            StringBuilder values = x < 0 ? new StringBuilder("-") : new StringBuilder();

            while (x != 0)
            {
                values.Append(Math.Abs(x % 10));
                x = x / 10;
            }

            if (int.TryParse(values.ToString(), out int result))
            {
                return result;
            }
            return 0;
        }
    }
}
