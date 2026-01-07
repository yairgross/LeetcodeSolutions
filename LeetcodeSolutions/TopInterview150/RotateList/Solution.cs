namespace TopInterview150.RotateList;

// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
// https://leetcode.com/problems/rotate-list/

public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || k == 0)
            return head;

        // 1. Find last node and get length
        ListNode last = head;
        int len = 1;
        while (last.next != null)
        {
            last = last.next;
            len++;
        }

        // 2. calculate k % n
        k %= len;
        // 3. if k % n == 0, return original head
        if (k == 0)
            return head;

        int newHeadIdx = len - k - 1;

        // 4. find node at indices n-k (new head), n-k-1 (new tail)
        ListNode curr = head;
        int i = 0;

        while (i < newHeadIdx)
        {
            curr = curr.next;
            i++;
        }

        // 5. adjust pointers
        ListNode newHead = curr.next;
        last.next = head;
        curr.next = null;

        // 6. return new head
        return newHead;
    }
}