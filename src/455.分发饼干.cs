/*
 * @lc app=leetcode.cn id=455 lang=csharp
 *
 * [455] 分发饼干
 */

// @lc code=start
using System;
public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        var res = 0;
        Array.Sort(g);
        Array.Sort(s);
        var gIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = gIndex; j < g.Length; j++)
            {
                if (s[i] >= g[j])
                {
                    res++;
                    gIndex++;
                    break;
                }
            }
        }
        return res;
    }
}
// @lc code=end

