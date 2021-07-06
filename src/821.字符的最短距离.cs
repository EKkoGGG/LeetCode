/*
 * @lc app=leetcode.cn id=821 lang=csharp
 *
 * [821] 字符的最短距离
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int n = s.Length;
        var ans = new int[n];
        var prev = int.MinValue / 2;

        for (int i = 0; i < n; i++)
        {
            if ((char)s[i] == c)
            {
                prev = i;
            }
            ans[i] = i - prev;
        }

        prev = int.MaxValue / 2;
        for (int i = n - 1; i >= 0; i--)
        {
            if ((char)s[i] == c)
            {
                prev = i;
            }
            ans[i] = Math.Min(ans[i], prev - i);
        }
        return ans;
    }
}
// @lc code=end

