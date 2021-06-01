/*
 * @lc app=leetcode.cn id=191 lang=csharp
 *
 * [191] 位1的个数
 */

// @lc code=start
public class Solution
{
    public int HammingWeight(uint n)
    {
        var res = 0;
        var top = 1U << 31;
        for (int i = 0; i < 32; i++)
        {
            if ((top & n) != 0)
            {
                res++;
            }
            top >>= 1;
        }
        return res;
    }
}
// @lc code=end

