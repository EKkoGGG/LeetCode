/*
 * @lc app=leetcode.cn id=190 lang=csharp
 *
 * [190] 颠倒二进制位
 */

// @lc code=start
public class Solution
{
    public uint reverseBits(uint n)
    {
        uint res = 0;
        // 代表二进制的 1000 000 ... 0000 （32位）
        uint top = 1U << 31;
        // 代表二进制的 0001
        uint bottom = 1;
        for (int i = 0; i < 32; i++)
        {
            // top 与输入参数n按位与
            // 如果为0 ,代表 n 在 top 为1的位置不是1
            res |= (top & n) == 0 ? 0 : bottom;
            top >>= 1;
            bottom <<= 1;
        }
        return res;
    }
}
// @lc code=end

