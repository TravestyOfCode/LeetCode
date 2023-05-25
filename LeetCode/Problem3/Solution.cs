using System.Collections.Generic;

namespace LeetCode.Problem3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {

            // Holds the current substring we are building
            List<char> characters = new List<char>();

            // The maximum length substring we have found so far
            int maxLengthFound = 0;

            foreach (var c in s)
            {
                if (characters.Contains(c))
                {
                    // Is this the biggest substring we've found?
                    if (maxLengthFound < characters.Count)
                    {
                        maxLengthFound = characters.Count;
                    }

                    // Remove previous substring up to and including
                    // the duplicate character.
                    characters.RemoveRange(0, characters.IndexOf(c) + 1);
                }

                characters.Add(c);
            }

            // Return either our current substring length or max found if larger
            if (maxLengthFound < characters.Count)
            {
                return characters.Count;
            }

            return maxLengthFound;
        }

        public string StringOfLongestSubstring(string s)
        {
            List<char> letters = new List<char>();

            int maxLengthFound = 0;
            string maxString = string.Empty;

            foreach (char c in s)
            {
                if (!letters.Contains(c))
                {
                    letters.Add(c);
                }
                else
                {
                    // We have a duplicate detected. Is our current Max
                    // larger than our current run?
                    if(maxLengthFound < letters.Count)
                    {
                        // Save our longest string
                        maxString = string.Join("", letters);
                        maxLengthFound = letters.Count;
                    }

                    // Remove everything from our list up to (and including) our duplicate
                    int index = letters.IndexOf(c);
                    letters.RemoveRange(0, index + 1);

                    // Add our character and continue. Max will remember the longest
                    // value that we had.                    
                    letters.Add(c);
                }
            }

            // Do a final check to see if our current list is
            // longer than our oldest found
            if(maxLengthFound < letters.Count)
            {
                return string.Join("", letters);
            }
            return maxString;
        }
    }
}
