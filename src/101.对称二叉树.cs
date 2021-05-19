/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    // 递归
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return false;
        else return Check(root.left, root.right);
    }
    public bool Check(TreeNode leftNode, TreeNode rightNode)
    {
        if (leftNode == null && rightNode == null) return true;
        if (leftNode == null || rightNode == null) return false;
        return (leftNode.val == rightNode.val)
        && Check(leftNode.left, rightNode.right)
        && Check(leftNode.right, rightNode.left);
    }

    // 迭代
    public bool IsSymmetric(TreeNode root)
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(root);
        while (q.Count != 0)
        {
            TreeNode t1 = q.Dequeue();
            TreeNode t2 = q.Dequeue();
            if (t1 == null && t2 == null) continue;
            if (t1 == null || t2 == null) return false;
            if (t1.val != t2.val) return false;
            q.Enqueue(t1.left);
            q.Enqueue(t2.right);
            q.Enqueue(t1.right);
            q.Enqueue(t2.left);
        }
        return true;
    }
}
// @lc code=end

