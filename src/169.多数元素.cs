/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 多数元素
 */

// @lc code=start
using System.Collections;
using System.Collections.Generic;
public class Solution
{
    // 哈希字典
    public int MajorityElement(int[] nums)
    {
        int maxKey = 0;
        int maxVal = int.MinValue;
        var dic = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (!dic.ContainsKey(item))
            {
                dic.Add(item, 1);
            }
            else
            {
                dic[item] += 1;
            }
        }

        foreach (KeyValuePair<int, int> dicItem in dic)
        {
            if (dicItem.Value > maxVal)
            {
                maxVal = dicItem.Value;
                maxKey = dicItem.Key;
            }
        }

        return maxKey;
    }

    // 位运算
    public int MajorityElement(int[] nums)
    {
        
    }
}
// @lc code=end

