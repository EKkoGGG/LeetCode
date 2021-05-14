/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除有序数组中的重复项
 */

// @lc code=start
using System.Linq;
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (!nums.Any()) return 0;
        var head = nums[0];
        var index = 1;
        var headIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != head)
            {
                head = nums[i];
                headIndex = i;
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
}
// @lc code=end

