using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems10To19.Problem13
{
    public class SecondAttempt
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> numerals = new Dictionary<char, int>
            {
                { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
            };

            int result = 0;
            int current = 0;
            for (int index = 0; index < s.Length - 1; index++)
            {
                current = numerals[s[index]];
                // Check if the next numer is larger than our current
                if (numerals[s[index+1]] > current)
                {
                    result += current * -1;
                }
                else
                {
                    result += current;
                }
            }
            // Get the last character
            result += numerals[s[s.Length - 1]];

            return result;
        }
    }
}
