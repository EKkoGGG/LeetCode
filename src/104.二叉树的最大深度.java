import java.util.LinkedList;
import java.util.Queue;

import javax.swing.tree.TreeNode;

/*
 * @lc app=leetcode.cn id=104 lang=java
 *
 * [104] 二叉树的最大深度
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    // DFS 深度优先搜索，顶向下
    public int maxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        return check(root,1);
    }

    public int check(TreeNode root,int depth){
        if (root == null) {
            return depth--;
        }
        if (root.left == null && root.right == null) {
            return depth;
        }
        depth++;
        int leftDepth = check(root.left,depth);
        int rightDepth = check(root.right,depth);
        int maxDepth = Math.max(leftDepth, rightDepth);
        return maxDepth;
    }

    // DFS 深度优先搜索，底向上
    public int maxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        } else {
            int leftDepth = maxDepth(root.left);
            int rightDepth = maxDepth(root.right);
            return Math.max(leftDepth, rightDepth) + 1;
        }
    }

    // BFS 迭代
    public int maxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        Queue<TreeNode> q = new LinkedList<>();
        q.offer(root);
        int depth = 0;
        while (q.size() > 0) {
            int size = q.size();
            while (size > 0) {
                TreeNode t = q.poll();
                if (t.left != null) {
                    q.offer(t.left);
                }
                if (t.right != null) {
                    q.offer(t.right);
                }
                size--;
            }
            depth++;
        }
        return depth;
    }
}
// @lc code=end

