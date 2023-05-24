using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // Adapted from https://www.youtube.com/watch?v=t0Cq6tVNRBA
    public class MinIntHeap
    {        
        private int capacity;
        private int size;
        private int[] items;

        public int Size => size;

        public MinIntHeap(int initialCapacity = 10)
        {
            capacity = initialCapacity;
            size = 0;
            items = new int[capacity];
        }

        private int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
        private int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;
        private int GetParentIndex(int childIndex) => (childIndex - 1) / 2;

        private bool HasLeftChild(int index) => GetLeftChildIndex(index) < size;
        private bool HasRightChild(int index) => GetRightChildIndex(index) < size;
        private bool hasParent(int index) => GetParentIndex(index) >= 0;

        private int LeftChild(int index) => items[GetLeftChildIndex(index)];
        private int RightChild(int index) => items[GetRightChildIndex(index)];
        private int Parent(int index) => items[GetParentIndex(index)];

        private void Swap(int index1, int index2)
        {
            int temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }

        private void EnsureExtraCapacity()
        {
            if(size == capacity)
            {
                int[] temp = new int[capacity * 2];
                Array.Copy(items, temp, capacity);
                items = temp;
                capacity *= 2;
            }
        }

        public int Peek()
        {
            if (size == 0)
                throw new InvalidOperationException("Heap is empty.");

            return items[0];
        }

        public int Poll()
        {
            if (size == 0)
                throw new InvalidOperationException("Heap is empty.");
            int item = items[0];

            items[0] = items[size - 1];

            size--;

            HeapifyDown();

            return item;
        }

        public void Add(int item)
        {
            EnsureExtraCapacity();
            items[size] = item;
            size++;
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            int index = size - 1;
            while(hasParent(index) && Parent(index) > items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (items[index] < items[smallerChildIndex])
                {
                    break;
                } else
                {
                    Swap(index, smallerChildIndex);                    
                }

                index = smallerChildIndex;
            }
        }
    }

    public class KthLargest
    {
        //PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        MinIntHeap queue = new MinIntHeap();
        int size = 1;

        public KthLargest(int k, int[] nums)
        {
            size = k;
            foreach (var num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            queue.Add(val); //.Enqueue(val, val);
            if (queue.Size > size) //.Count > size)
            {
                queue.Poll();//.Dequeue();
            }
            return queue.Peek();
        }

    }
}
