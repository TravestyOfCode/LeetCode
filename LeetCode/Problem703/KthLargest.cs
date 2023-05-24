using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problem703;

public class KthLargest
{
    private List<int> Nums;

    private int K;

    public KthLargest(int k, int[] nums)
    {
        Nums = nums.ToList();
        K = k;
    }

    public int Add(int val)
    {
        Nums.Add(val);
        Nums.Sort();
        return Nums[Nums.Count - K];
    }
}
