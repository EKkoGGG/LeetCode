/*
 * @lc app=leetcode.cn id=108 lang=csharp
 *
 * [108] 将有序数组转换为二叉搜索树
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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return CreateBST(nums, 0, nums.Length - 1);
    }

    public TreeNode CreateBST(int[] nums, int start, int end)
    {
        if (start > end) return null;
        int mid = (start + end) / 2;
        var node = new TreeNode(nums[mid]);
        node.left = CreateBST(nums, start, mid - 1);
        node.right = CreateBST(nums, mid + 1, end);
        return node;
    }
}
// @lc code=end

