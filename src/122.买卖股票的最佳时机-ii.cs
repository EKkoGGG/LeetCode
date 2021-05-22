/*
 * @lc app=leetcode.cn id=122 lang=csharp
 *
 * [122] 买卖股票的最佳时机 II
 */

// @lc code=start
public class Solution
{
    // 贪心
    public int MaxProfit(int[] prices)
    {
        var length = prices.Length;
        if (length == 1) return 0;
        int profit = 0;
        for (int i = 1; i < length; i++)
        {
            profit += Math.Max(prices[i] - prices[i - 1], 0);
        }
        return profit;
    }
}
// @lc code=end

