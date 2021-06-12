/*
 * @lc app=leetcode.cn id=342 lang=csharp
 *
 * [342] 4的幂
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        var remainder = 0;
        while (n > 1)
        {
            remainder = n % 4;
            if (remainder != 0)
            {
                return false;
            }
            n /= 4;
        }
        return true;
    }
}
// @lc code=end

