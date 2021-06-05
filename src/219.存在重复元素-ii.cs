/*
 * @lc app=leetcode.cn id=219 lang=csharp
 *
 * [219] 存在重复元素 II
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    // 哈希表
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dic = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i],i);
            }
            else if (Math.Abs(dic[nums[i]] - i) <= k)
            {
                return true;
            }
            else
            {
                dic[nums[i]] = i;
            }            
        }
        return false;
    }
}
// @lc code=end

