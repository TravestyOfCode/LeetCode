using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems10To19.Problem11
{
    public class TwoPointer
    {
        public int MaxArea(int[] height)
        {
            // Start at the left and right and calculate the area
            // Then move in on either side of which ever was shortest
            int maxArea = 0;

            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                int area = (j - i) * Math.Min(height[i], height[j]);
                if (area > maxArea)
                    maxArea = area;

                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return maxArea;
        }
    }
}
