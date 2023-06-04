using System;
using System.Collections.Generic;

namespace LeetCode.Problems1To9.Problem2
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }

            int sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;

            carry = sum / 10;

            return new ListNode(sum % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
        }
    }
}
