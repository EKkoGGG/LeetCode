/*
 * @lc app=leetcode.cn id=1332 lang=csharp
 *
 * [1332] 删除回文子序列
 */

// @lc code=start
public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        if (s == string.Empty)
        {
            return 0;
        }
        if (s == new string(s.Reverse().ToArray()))
        {
            return 1;
        }
        return 2;
    }
}
// @lc code=end

