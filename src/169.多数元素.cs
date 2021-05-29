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

    // 排序
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }

    // 摩尔投票法
    public int MajorityElement(int[] nums)
    {
        var card_num = nums[0];
        var count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                card_num = nums[i];
                count = 1;
            }
            else if (nums[i] == card_num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return card_num;
    }
}
// @lc code=end

