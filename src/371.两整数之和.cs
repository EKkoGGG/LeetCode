/*
 * @lc app=leetcode.cn id=371 lang=csharp
 *
 * [371] 两整数之和
 */

// @lc code=start
public class Solution
{
    public int GetSum(int a, int b)
    {
        if (a == 0) return b;
        if (b == 0) return a;
        while (b != 0)
        {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }
}
// @lc code=end

