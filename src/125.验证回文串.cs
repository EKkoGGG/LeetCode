/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 */

// @lc code=start
using System.Text.RegularExpressions;
public class Solution
{
    // 迭代
    public bool IsPalindrome(string s)
    {
        s = s.ToUpper();
        var pattern = "[A-Z0-9]";
        var endIndex = s.Length - 1;
        for (int i = 0; i < s.Length; i++)
        {
            var startStr = s[i].ToString();
            if (Regex.IsMatch(startStr, pattern))
            {
                for (int j = endIndex; j >= 0; j--)
                {
                    var endStr = s[j].ToString();
                    if (Regex.IsMatch(endStr, pattern))
                    {
                        if (startStr == endStr)
                        {
                            j--;
                            endIndex = j;
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
}
// @lc code=end

