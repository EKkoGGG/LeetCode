/*
 * @lc app=leetcode.cn id=198 lang=csharp
 *
 * [198] 打家劫舍
 */

// @lc code=start
public class Solution
{
    // 动态规划
    public int Rob(int[] nums)
    {
        var length = nums.Length;
        if (length == 1) return nums[0];
        var first = nums[0];
        var second = Math.Max(nums[0], nums[1]);
        var maxVal = Math.Max(first,second);
        for (int i = 2; i < length; i++)
        {
            var cur = Math.Max(second, nums[i] + first);
            maxVal = Math.Max(maxVal,cur);
            first = second;
            second = cur;
        }
        return maxVal;
    }
}
// @lc code=end

