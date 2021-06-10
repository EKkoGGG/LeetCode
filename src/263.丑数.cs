/*
 * @lc app=leetcode.cn id=263 lang=csharp
 *
 * [263] 丑数
 */

// @lc code=start
public class Solution
{
    public bool IsUgly(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        var list = new List<int>(){2,3,5};
        foreach (var item in list)
        {
            while (n % item == 0)
            {
                n /= item;
            }
        }
        return n == 1;
    }
}
// @lc code=end

