/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var dic = new Dictionary<int,int>();
        var res = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!dic.ContainsKey(nums1[i]))
            {
                dic.Add(nums1[i],1);
            }
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (dic.ContainsKey(nums2[i]) && !res.Contains(nums2[i]))
            {
               res.Add(nums2[i]);
            }
        }
        return res.ToArray();
    }
}
// @lc code=end

