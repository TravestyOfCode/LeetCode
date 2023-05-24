using System.Collections.Generic;

namespace LeetCode.Problem1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {
                // Get our difference from our target
                int diff = target - nums[index];

                // Do we have a entry for this value
                if (values.ContainsKey(diff))
                {
                    return new int[2] { index, values[diff] };
                }

                if (!values.ContainsKey(nums[index]))
                {
                    values.Add(nums[index], index);
                }
            }
            // We didn't find a match.
            return null;
        }
    }
}
