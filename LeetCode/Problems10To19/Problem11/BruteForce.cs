using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems10To19.Problem11
{
    public class BruteForce
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
                        
            for(int index1 = 0; index1 < height.Length - 1;index1++)
            {
                for(int index2 = 1; index2<height.Length;index2++)
                {
                    // Area of two would be difference in indexes (width) * min of the two
                    int area = Math.Abs(index1 - index2) * (Math.Min(height[index1], height[index2]));
                    if (area > maxArea)
                        maxArea = area;
                }
            }

            return maxArea;
        }
    }
}
