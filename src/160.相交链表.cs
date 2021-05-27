/*
 * @lc app=leetcode.cn id=160 lang=csharp
 *
 * [160] 相交链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
using System.Collections;
using System.Collections.Generic;
public class Solution
{
    // 哈希表
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var hs = new HashSet<ListNode>();
        var tempNode = headA;
        while (tempNode != null)
        {
            if (!hs.Contains(tempNode))
            {
                hs.Add(tempNode);
            }
            else
            {
                return tempNode;
            }
            tempNode = tempNode.next;
        }
        tempNode = headB;
        while (tempNode != null)
        {
            if (!hs.Contains(tempNode))
            {
                hs.Add(tempNode);
            }
            else
            {
                return tempNode;
            }
            tempNode = tempNode.next;
        }
        return null;
    }
}
// @lc code=end

