using System;

namespace LeetCode.Problems1To9.Problem4
{
    public class Solution
    {
        // Given two sorted arrays nums1 and nums2 of size m and n respectively,
        // return the median of the two sorted arrays.
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            return SecondAttempt(nums1, nums2);
        }

        private double FirstAttempt(int[] nums1, int[] nums2)
        {
            // Combine the arrays
            int length = nums1.Length + nums2.Length;
            var combinedArray = new int[length];
            Array.Copy(nums1, combinedArray, nums1.Length);
            Array.Copy(nums2, 0, combinedArray, nums1.Length, nums2.Length);

            // Sort
            Array.Sort(combinedArray);

            // If even array, get the average of the two
            if (length % 2 == 0)
            {
                return (combinedArray[length / 2] + (double)combinedArray[length / 2 - 1]) / 2;
            }

            return combinedArray[length / 2];
        }

        private double SecondAttempt(int[] nums1, int[] nums2)
        {
            // Calculate the length for the combined array
            int length = nums1.Length + nums2.Length;

            var combinedNums = new int[length];

            int i = 0; // nums1 index
            int j = 0; // nums2 index
            int k = 0; // combined index;

            while (k < length)
            {
                if (i == nums1.Length)
                {
                    // Copy rest of array 2 into combined
                    Array.Copy(nums2, j, combinedNums, k, length - k);
                    k = length;
                }
                else if (j == nums2.Length)
                {
                    // Copy rest of array 1 into combined
                    Array.Copy(nums1, i, combinedNums, k, length - k);
                    k = length;
                }
                else if (nums1[i] < nums2[j])
                {
                    combinedNums[k] = nums1[i];
                    i++;
                    k++;
                }
                else
                {
                    combinedNums[k] = nums2[j];
                    j++;
                    k++;
                }
            }

            // If even array, get the average of the two
            if (length % 2 == 0)
            {
                return (combinedNums[length / 2] + (double)combinedNums[length / 2 - 1]) / 2;
            }

            return combinedNums[length / 2];
        }
    }
}
