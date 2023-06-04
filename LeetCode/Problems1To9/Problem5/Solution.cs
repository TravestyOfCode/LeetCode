using System;
using System.Collections.Generic;

namespace LeetCode.Problems1To9.Problem5
{
    public class Solution
    {
        public string LongestPalindrome1(string s)
        {
            // 1 <= s.Length <= 1000;

            int maxSubstring = 1;
            string result = s.Substring(0, 1); // would s[0].ToString() be faster?
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int index = 0; index < s.Length; index++)
            {
                char c = s[index];

                // Have we tracked this letter before
                if (!letters.ContainsKey(c))
                {
                    // Start tracking, but can't be palindrome yet
                    // as it has to start and end with the same char.
                    letters.Add(c, index);
                }
                else
                {
                    // Is the length of the first instance to our current index larger
                    // than our current max? No need to check if palindrome if it can't
                    // be the largest.
                    if (index + 1 - letters[c] > maxSubstring)
                    {
                        // Get the substring from first letter to current and check
                        // if it's the same reversed.
                        string current = s.Substring(letters[c], index - letters[c] + 1);
                        if (current == Reverse(current))
                        {
                            // Update our max length and current longest string.
                            maxSubstring = index + 1 - letters[c];
                            result = current;
                        }
                    }
                }
            }

            return result;
        }

        public string LongestPalindrome2(string s)
        {
            int maxSubstring = 1;
            string result = s.Substring(0, 1); // would s[0].ToString() be faster?
            Dictionary<char, List<int>> letters = new Dictionary<char, List<int>>();

            for (int index = 0; index < s.Length; index++)
            {
                char c = s[index];

                // Have we tracked this letter before
                if (!letters.ContainsKey(c))
                {
                    // Start tracking, but can't be palindrome yet
                    // as it has to start and end with the same char.
                    letters.Add(c, new List<int>() { index });
                }
                else
                {
                    // For each of the indexes of this letter, check if
                    // the current index - letter index is greater than our
                    // current max.
                    foreach (int letterIndex in letters[c])
                    {
                        if (index + 1 - letterIndex > maxSubstring)
                        {
                            // Get the substring from first letter to current and check
                            // if it's the same reversed.
                            string current = s.Substring(letterIndex, index - letterIndex + 1);
                            if (current == Reverse(current))
                            {
                                // Update our max length and current longest string.
                                maxSubstring = index + 1 - letterIndex;
                                result = current;
                            }
                        }
                    }

                    // Add this index position for the letter for future checking
                    letters[c].Add(index);

                }
            }

            return result;
        }

        public string LongestPalindrome(string s)
        {
            int startPosition = 0;
            int endPosition = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // Check using i as 'center' point of palindrome
                int lenCenter = CheckForPalindrome(s, i - 1, i + 1);
                if (lenCenter > endPosition - startPosition + 1)
                {
                    startPosition = i - lenCenter / 2;
                    endPosition = i + lenCenter / 2;
                }

                // Check using i as middle point
                int lenEven = CheckForPalindrome(s, i, i + 1);
                if (lenEven > endPosition - startPosition)
                {
                    startPosition = i - lenEven / 2 + 1;
                    endPosition = i + lenEven / 2;
                }
            }

            return s.Substring(startPosition, endPosition - startPosition + 1);

        }

        public int CheckForPalindrome(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }

        public static string Reverse(string s)
        {
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            return new string(cArray);
        }
    }
}
