/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
using System.Linq;
using System.Collections.Generic;
public class Solution
{
    // 自己实现
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        var tempVal = 0;
        var maxVal = nums[0];
        var isBeginSum = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0 || isBeginSum)
            {
                if (isBeginSum) tempVal += nums[i];
                else tempVal = nums[i];

                if (tempVal < 1)
                {
                    isBeginSum = false;
                    continue;
                }
                isBeginSum = true;
            }
            else
            {
                tempVal = nums[i];
            }

            if (tempVal > maxVal) maxVal = tempVal;
        }
        return maxVal;
    }
}
// @lc code=end

