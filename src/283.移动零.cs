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
        for (int i = 0; i < length; i++)
        {
            if (nums[i] == 0)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
                continue;
            }
        }
    }
}
// @lc code=end

