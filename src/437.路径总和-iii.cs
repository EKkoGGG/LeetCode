/*
 * @lc app=leetcode.cn id=437 lang=csharp
 *
 * [437] 路径总和 III
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
    private int count;
    public int PathSum(TreeNode root, int targetSum)
    {
        count = 0;
        Dfs(root, targetSum, new List<int>());
        return count;
    }

    private void Dfs(TreeNode root, int sum, IList<int> sumResult)
    {
        if (root == null) return;

        var curValue = root.val;
        for (var i = 0; i < sumResult.Count; i++)
            sumResult[i] += curValue;
        sumResult.Add(curValue);

        foreach (var item in sumResult)
            if (item == sum) count++;

        Dfs(root.left, sum, sumResult);
        Dfs(root.right, sum, sumResult);

        for (var i = 0; i < sumResult.Count; i++)
            sumResult[i] -= curValue;
        sumResult.Remove(0);
    }

}
// @lc code=end

