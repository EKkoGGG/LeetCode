/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start

public class Solution
{
    // 哈希表解法
    public int[] TwoSum(int[] nums, int target)
    {
        var ht = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {                        
            if(ht.ContainsKey(target - nums[i]))
            {
                int val = (int)ht[target - nums[i]];
                return new int[2]{i,val};
            }
            ht.Add(nums[i],i);
        }
        return new int[2];
    }

    // 暴力解法
    public int[] TwoSum(int[] nums, int target)
    {
        var n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j };
                }
            }
        }
        return new int[2];
    }
}
// @lc code=end

