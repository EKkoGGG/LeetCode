/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] += 1;
                return digits;
            }
        }
        var list = new List<int>() { 1 };
        foreach (int item in digits)
        {
            list.Add(0);
        }
        return list.ToArray();
    }
}
// @lc code=end

