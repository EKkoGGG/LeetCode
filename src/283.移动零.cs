/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 */

// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var length = nums.Length;
        var j = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j++;                
            }
        }
    }
}
// @lc code=end

