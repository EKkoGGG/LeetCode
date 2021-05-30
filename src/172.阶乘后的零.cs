/*
 * @lc app=leetcode.cn id=172 lang=csharp
 *
 * [172] 阶乘后的零
 */

// @lc code=start
public class Solution
{
    // 计算阶乘后有多少个0
    // 只要判断 n * (n - 1) * ... 1 
    // n 由多少个5 组成 （因为2*5 = 10，2肯定够）
    public int TrailingZeroes(int n)
    {
        var count = 0;
        while (n > 0)
        {
            n /= 5;
            count += n;
        }
        return count;
    }
}
// @lc code=end

