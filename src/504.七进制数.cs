/*
 * @lc app=leetcode.cn id=504 lang=csharp
 *
 * [504] 七进制数
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public string ConvertToBase7(int num)
    {
        var res = string.Empty;
        var remainders = new List<int>();
        if (num < 0)
        {
            num = -num;
            res = "-";
        }
        while (num >= 7)
        {
            remainders.Add(num % 7);
            num /= 7;
        }
        remainders.Add(num);
        for (int i = remainders.Count - 1; i >= 0; i--)
        {
            res += remainders[i];
        }
        return res;
    }
}
// @lc code=end

