/*
 * @lc app=leetcode.cn id=206 lang=csharp
 *
 * [206] 反转链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 using System.Collections;
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        var st = new Stack<int>();
        var cur = head;
        while (cur != null)
        {
            st.Push(cur.val);
            cur = cur.next;
        }
        cur = head;
        while (cur != null)
        {
            cur.val = st.Pop();
            cur = cur.next;
        }
        return head;
    }
}
// @lc code=end

