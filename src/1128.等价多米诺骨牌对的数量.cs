/*
 * @lc app=leetcode.cn id=1128 lang=csharp
 *
 * [1128] 等价多米诺骨牌对的数量
 */

// @lc code=start
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        int res = 0;
        var list = new int[100];
        foreach (var item in dominoes)
        {
            if (item[0] > item[1])
            {
                var temp = item[0];
                item[0] = item[1];
                item[1] = temp;
            }
            var num = item[0] * 10 + item[1];
            res += list[num];
            list[num]++;
        }
        return res;
    }
}
// @lc code=end

