/*
 * @lc app=leetcode.cn id=575 lang=csharp
 *
 * [575] 分糖果
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        var getCandiesNum = candyType.Length / 2;
        var dic = new Dictionary<int,int>();
        for (int i = 0; i < candyType.Length; i++)
        {
            if (dic.ContainsKey(candyType[i]))
            {
                dic[candyType[i]] += 1;
            }
            else
            {
                dic.Add(candyType[i],1);
            }
        }
        var girlCandiesNum = 0;
        while (girlCandiesNum < getCandiesNum)
        {
            foreach (KeyValuePair<int,int> item in dic)
            {
                if (item.Value > 0)
                {
                    girlCandiesNum++;
                    dic[item.Key] -= 1;
                }
            }
        }      
    }
}
// @lc code=end

