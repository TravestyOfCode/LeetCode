using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems10To19.Problem12
{
    public class SubtractMethod
    {
        public string IntToRoman(int num)
        {
            Dictionary<int, string> numerals = new Dictionary<int, string>()
            {
                { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD"},
                { 100, "C" }, { 90, "XC" }, { 50, "L"}, { 40, "XL" },
                { 10, "X" }, { 9, "IX" }, { 5, "V" }, { 4, "IV" },
                { 1, "I" }
            };

            StringBuilder builder = new StringBuilder();

            foreach(var n in numerals)
            {
                while(num >= n.Key)
                {
                    num = num - n.Key;
                    builder.Append(n.Value);
                }
            }

            return builder.ToString();
        }
    }
}
