/*
 * @lc app=leetcode.cn id=203 lang=csharp
 *
 * [203] 移除链表元素
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
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var res = new ListNode(0);
        res.next = head;
        
        var pre = res;
        var cur = head;
        while (cur != null)
        {
            if (cur.val == val)
            {
                pre.next = cur.next;
            }
            else
            {
                pre = cur;
            }
            cur = cur.next;
        }

        return res.next;
    }
}
// @lc code=end

