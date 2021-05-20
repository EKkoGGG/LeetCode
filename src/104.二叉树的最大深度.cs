/*
 * @lc app=leetcode.cn id=104 lang=csharp
 *
 * [104] 二叉树的最大深度
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
    // DFS 递归，顶向下
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        else return CheckDepth(root, 1);
    }

    public int CheckDepth(TreeNode root, int curDepth)
    {
        if (root == null) return curDepth;
        if (root.left == null && root.right == null) return curDepth;
        curDepth++;
        var curL = CheckDepth(root.left, curDepth);
        var curR = CheckDepth(root.right, curDepth);
        return Math.Max(curL, curR);
    }

    // DFS 递归，底向上
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        else
        {
            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }

    // BFS 迭代
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int depth = 0;
        while (q.Count > 0)
        {
            int size = q.Count;
            while (size > 0)
            {
                TreeNode t = q.Dequeue();
                if(t.left != null) q.Enqueue(t.left);
                if(t.right != null) q.Enqueue(t.right);
                size--;
            }
            depth++;
        }
        return depth;
    }

}
// @lc code=end

