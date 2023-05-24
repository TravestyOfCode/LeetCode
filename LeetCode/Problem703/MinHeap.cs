using System;

namespace LeetCode.Problem703
{
    public class MinHeap
    {
        private int[] items;
        private int capacity;
        private int heap_size;


        public MinHeap(int k, int[] nums)
        {
            capacity = k;
            items = new int[k];
            Array.Fill(items, int.MinValue);
            
            foreach(int num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            // Check if our value is greater than the current root
            if(val >= items[0])
            {
                // Shift all elements to the right so we can insert our new max
                ShiftRight(0);
                
                items[0] = val;

                heap_size += 1;
            }
            else
            {
                // Travese the children to see if we need to add this value
                for(int index=0;index<capacity-1;index++)
                {
                    if (items[index+1] < val)
                    {
                        // Shift right from this child
                        ShiftRight(index + 1);

                        // Insert into our child index
                        items[index + 1] = val;
                        heap_size += 1;
                        break;
                    }
                }
            }

            // Return the last element or at heap_size if we don't have a full heap.
            return heap_size + 1 < capacity ? items[heap_size] : items[capacity-1];
        }

        private void ShiftRight(int startIndex)
        {
            for (int index = capacity - 2; index >= startIndex; index--)
            {
                items[index + 1] = items[index];
            }
        }
    }
}
