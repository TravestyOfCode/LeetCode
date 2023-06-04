using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems1To9.Problem8
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            int result = 0;
            int maxVal = int.MaxValue / 10;
            bool isNegative = false;

            int index = 0;

            // Skip over any starting whitespace
            while (index < s.Length && s[index] == ' ')
            {
                index++;
            }

            if (index >= s.Length)
                return result;

            // Check for a positive/negative sign
            if (s[index] == '+' || s[index] == '-')
            {
                if (s[index] == '-')
                {
                    isNegative = true;
                }
                index++;
            }

            // Get the rest of the numbers until we hit the end of the
            // string or the character isn't a number.
            while (index < s.Length && s[index] >= '0' && s[index] <= '9')
            {
                // Check if we are above the maxValue or if we are
                // equal to it and the next number is more than 7.
                if (result > maxVal || result == maxVal && s[index] - '0' > 7)
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }

                // Multiply result by 10 and add the next number
                result = result * 10 + (s[index] - '0');
                index++;
            }

            return isNegative ? result * -1 : result;
        }
    }
}
