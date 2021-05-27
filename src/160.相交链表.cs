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

    // 双指针
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var pA = headA;
        var pB = headB;
        var isARep = false;
        var isBRep = false;
        while (pA != null || pB != null)
        {
            if (pA == pB)
            {
                return pA;
            }
            if (pA == null && !isARep)
            {
                isARep = true;
                pA = headB;
            }
            else if (pA != null)
            {
                pA = pA.next;
            }
            if (pB == null && !isBRep)
            {
                isBRep = true;
                pB = headA;
            }
            else if (pB != null)
            {
                pB = pB.next;
            }
        }
        return null;
    }

    // 双指针
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null)
        {
            return null;
        }
        var pA = headA;
        var pB = headB;
        while (pA != pB)
        {
            if (pA == null)
            {
                pA = headB;
            }
            else
            {
                pA = pA.next;
            }
            if (pB == null)
            {
                pB = headA;
            }
            else
            {
                pB = pB.next;
            }
        }
        return pA;
    }
}
// @lc code=end

