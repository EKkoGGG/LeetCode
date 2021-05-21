/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public class Solution
{
    // 暴力法
    public int MaxProfit(int[] prices)
    {
        int maxVal = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            int cur = prices[i];
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (cur < prices[j])
                {
                    maxVal = Math.Max(maxVal, prices[j] - cur);
                }
            }
        }
        return maxVal;
    }
    // 一次遍历
    public int MaxProfit(int[] prices)
    {
        int maxVal = 0;
        int minItem = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] <= minItem)
            {
                minItem = prices[i];
            }
            else
            {
                maxVal = Math.Max(maxVal, prices[i] - minItem);
            }
        }
        return maxVal;
    }

}
// @lc code=end

