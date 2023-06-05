using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems10To19.Problem14
{
    public class FirstAttempt
    {
        public string LongestCommonPrefix(string[] strs)
        {
            // Find the longest common prefix amongst an array of strings
            // If no common prefix, return an empty string.
            if (strs.Length == 0)
                return string.Empty;

            string result = string.Empty;
            for(int index = 0; index < strs[0].Length; index++)
            {
                char c = strs[0][index];
                for(int subStrs = 1; subStrs < strs.Length; subStrs++)
                {
                    if (strs[subStrs].Length <= index ||  strs[subStrs][index] != c)
                        return result;
                }
                result += c;
            }            

            return result;
        }
    }
}
