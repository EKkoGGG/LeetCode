/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */

// @lc code=start
using System.Collections.Generic;
using System.Collections;
public class Solution
{
    // 哈希
    public int SingleNumber(int[] nums)
    {
        var hs = new HashSet<int>();
        foreach (var item in nums)
        {
            if (!hs.Contains(item))
            {
                hs.Add(item);
            }
            else
            {
                hs.Remove(item);
            }
        }
        return hs.First();
    }

    // 异或
    public int SingleNumber(int[] nums)
    {
        int res = 0;
        foreach (var item in nums)
        {
            res ^= item;
        }
        return res;
    }
}
// @lc code=end

