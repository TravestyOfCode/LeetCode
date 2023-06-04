using System;

namespace LeetCode.Problems1To9.Problem6
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            // Create a 2d array to hold the zig zag characters,
            // though this wastes space
            int width = (int)Math.Ceiling(s.Length / 2.0);
            char?[] letters = new char?[width * numRows];

            // Fill the rows and columns based on zig zag
            for (int index = 0; index < s.Length; index++)
            {
                for (int column = 0; column < width; column++)
                {
                    // Fill the column down
                    for (int row = 0; row < numRows; row++)
                    {
                        if (index >= s.Length)
                            break;

                        letters[row * width + column] = s[index++];
                    }

                    // Fill the zig zag back up
                    for (int row = numRows - 2; row > 0; row--)
                    {
                        if (index >= s.Length)
                            break;

                        column++; // Move to the next column
                        letters[row * width + column] = s[index++];
                    }
                }
            }

            return string.Join(string.Empty, letters);
        }
    }
}
