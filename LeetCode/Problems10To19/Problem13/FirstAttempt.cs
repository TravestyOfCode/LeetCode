using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems10To19.Problem13
{
    public class FirstAttempt
    {
        public int RomanToInt(string s)
        {
            int result = 0;

            if (string.IsNullOrWhiteSpace(s))
                return result;

            Dictionary<string, int> doubleNumerals = new Dictionary<string, int>
            {
                { "IV", 4 }, { "IX", 9 }, { "XL", 40 }, { "XC", 90 }, { "CD", 400 }, { "CM", 900 }
            };

            Dictionary<char, int> singleNumerals = new Dictionary<char, int>
            {
                { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
            };

            for(int index=s.Length-1;index>=0;index--)
            {
                if (index != 0)
                {
                    string key = s.Substring(index - 1, 2);
                    if (doubleNumerals.ContainsKey(key))
                    {
                        result += doubleNumerals[key];
                        index--;
                        if(index==0)
                        {
                            return result;
                        }
                        continue;
                    }
                }
                result += singleNumerals[s[index]];                
            }

            return result;
        }
    }
}
