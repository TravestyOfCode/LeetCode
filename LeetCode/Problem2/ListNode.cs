namespace LeetCode.Problem2
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class ListNodeFactory
    {
        public static ListNode Create(params int[] values)
        {
            ListNode result = new ListNode(values[0]);
            ListNode next = result;
            for(int index=1;index<values.Length;index++)
            {
                next.next = new ListNode(values[index]);
                next = next.next;
            }
            return result;
        }
    }
}
