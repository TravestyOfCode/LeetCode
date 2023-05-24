using System.Collections.Generic;

namespace LeetCode.Problem703
{
    public class PQueue
    {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        int size = 1;

        public PQueue(int k, int[] nums)
        {
            size = k;
            foreach(var num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            queue.Enqueue(val, val);
            if (queue.Count > size)
            {
                queue.Dequeue();
            }
            return queue.Peek();
        }
    }
}
