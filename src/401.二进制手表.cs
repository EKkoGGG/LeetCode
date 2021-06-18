/*
 * @lc app=leetcode.cn id=401 lang=csharp
 *
 * [401] 二进制手表
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        var res = new List<string>();
        if (turnedOn == 0)
        {
            res.Add("0:00");
            return res;
        }
        if (turnedOn > 8)
        {
            return res;
        }
        for (int i = 1; i < 5; i++)
        {
            foreach (var hour in PossibleNumber(i))
            {
                foreach (var mintue in PossibleNumber(turnedOn - i))
                {
                    var mintueStr = mintue.ToString().PadLeft(2, '0');
                    res.Add($"{hour}:mintueStr");
                }
            }
        }
        return res;
    }

    public List<int> PossibleNumber(int count)
    {
        var res = new List<int>();

        return res;
    }
}
// @lc code=end

